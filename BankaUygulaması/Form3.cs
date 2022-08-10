using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulaması
{
    public partial class Form3 : Form
    {
        public bool isLogin = false;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id_textBox.Text))
            {
                MessageBox.Show("ID alanı boş olamaz. Lütfen geçerli bir tam sayı değeri giriniz.");
            }
            else
            {

                con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
                cmd = new SqlCommand();
                try
                {
                    con.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı sağlanamdı." + ex.Message);
                }
                if (!isLogin)
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT ID, Name, Surname FROM Worker WHERE ID = @WorkerID"; // add here sql command for to list all customers belong to the representative
                    cmd.Parameters.Add("@WorkerID", SqlDbType.Int);
                    cmd.Parameters["@WorkerID"].Value = id_textBox.Text;
                    cmd.Prepare();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        customerList_listBox.Items.Add(dr["ID"]);
                    }
                    dr.Close();
                }
                if (customerList_listBox.Items.Count == 0)
                {
                    isLogin = false;
                    MessageBox.Show("Giris yapılamadı.");
                }
                else
                {
                    isLogin = true;
                    id_textBox.ReadOnly = true;
                    login_button.Enabled = false;
                    idStatus_label.Visible = true;
                    idStatus_label.Text = id_textBox.Text;
                    idStatus_label.ForeColor = Color.DarkBlue;
                    loginStatus_label.Text = "Başarılı bir şekilde giriş yaptınız.";
                    loginStatus_label.ForeColor = Color.Green;
                    customerList_listBox.Items.Clear();
                    // yeni sorgu ile kullanıcıları çek
                    refreshTheList();
                }
            }
            
        }

        private void refreshTheList()
        {
            SqlCommand cmdCustomer = new SqlCommand();
            SqlDataReader drCustomer;
            cmdCustomer.CommandText = "SELECT ID FROM Customer WHERE repID = @workerID";
            cmdCustomer.Parameters.Add("@WorkerID", SqlDbType.Int);
            cmdCustomer.Parameters["@WorkerID"].Value = id_textBox.Text;
            cmdCustomer.Connection = con;
            cmdCustomer.Prepare();
            drCustomer = cmdCustomer.ExecuteReader();
            customerList_listBox.Items.Clear();
            while (drCustomer.Read())
            {
                customerList_listBox.Items.Add(drCustomer["ID"]);
            }
            drCustomer.Close();
        }

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
            
        }

        private void customerList_listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(customerList_listBox.SelectedItem.ToString()))
            {
                SqlCommand lscmd = new SqlCommand();
                SqlDataReader reader;
                lscmd.Connection = con;
                lscmd.CommandText = "SELECT * FROM Customer WHERE ID = @cusID";
                lscmd.Parameters.Add("@cusID", SqlDbType.Int);
                lscmd.Parameters["@cusID"].Value = customerList_listBox.SelectedItem.ToString();
                lscmd.Prepare();
                reader = lscmd.ExecuteReader();
                while (reader.Read())
                {
                    customerID_textBox.Text = reader["ID"].ToString();
                    name_textBox.Text = reader["Name"].ToString();
                    surname_textBox.Text = reader["Surname"].ToString();
                    address_textBox.Text = reader["Address"].ToString();
                    email_textBox.Text = reader["Email"].ToString();
                    phone_textBox.Text = reader["Phone"].ToString();
                }
                reader.Close();
            }
        }

        private void insertNewCustomer_button_Click(object sender, EventArgs e)
        {
            if(isLogin)
            {
                if(String.IsNullOrEmpty(id_textBox.Text) || String.IsNullOrEmpty(name_textBox.Text) || String.IsNullOrEmpty(surname_textBox.Text) || 
                    String.IsNullOrEmpty(address_textBox.Text) || String.IsNullOrEmpty(email_textBox.Text) || String.IsNullOrEmpty(phone_textBox.Text))
                {
                    MessageBox.Show("Lutfen tum alanlari doldurunuz.");
                }
                else
                {
                    // Yeni musteri ekleme islemi
                }
            }
            else
            {
                MessageBox.Show("Giris yapmadan yeni musteri ekleme islemi yapılamamktadır.");
            }
        }

        private void deleteCustomer_button_Click(object sender, EventArgs e)
        {
            if(deleteCustomer_checkBox.Checked)
            {
                if(customerList_listBox.SelectedItem == null)
                {
                    MessageBox.Show("Lutfen listeden silmek istediğiniz müşteriyi seçiniz.");
                }
                else
                {
                    string checkBal = "YOK";
                    // Check balances all accounts belong to the customer.
                    cmd = new SqlCommand();
                    cmd.CommandText = "SELECT SUM(Balance) FROM Account WHERE ID = @cusID";
                    cmd.Parameters.Add("@cusID", SqlDbType.Int);
                    cmd.Parameters["@cusID"].Value = customerList_listBox.SelectedItem.ToString();
                    cmd.Connection = con;
                    cmd.Prepare();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        checkBal = dr[0].ToString();
                    }
                    dr.Close();
                    // if all zero
                    if (checkBal == "0" || float.Parse(checkBal) < 0.01f)
                    {
                        SqlCommand dlCmd = new SqlCommand();
                        dlCmd.CommandText = "DELETE FROM Account WHERE ID = @cusID";
                        dlCmd.Parameters.Add("@cusID", SqlDbType.Int);
                        dlCmd.Parameters["@cusID"].Value = customerList_listBox.SelectedItem.ToString();
                        dlCmd.Connection = con;
                        dlCmd.Prepare();
                        dlCmd.ExecuteNonQuery();
                        dlCmd = new SqlCommand();
                        dlCmd.CommandText = "DELETE FROM Customer WHERE ID = @cusID";
                        dlCmd.Parameters.Add("@cusID", SqlDbType.Int);
                        dlCmd.Parameters["@cusID"].Value = customerList_listBox.SelectedItem.ToString();
                        dlCmd.Connection = con;
                        dlCmd.Prepare();
                        dlCmd.ExecuteNonQuery();
                        MessageBox.Show("Musteri silinmistir.");
                        refreshTheList();
                    }
                    else
                    {
                        MessageBox.Show("Hesapta para bulunmaktadır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lutfen müşteri silim kutusunu onaylayınız.");
            }
            
        }

        private void enableButtons()
        {
            approve_button.Enabled = true;
            reject_button.Enabled = true;
        }

        private void disableButtons()
        {
            approve_button.Enabled = false;
            reject_button.Enabled = false;
        }

        private void updateInfo_button_Click(object sender, EventArgs e)
        {               
            if (customerList_listBox.SelectedItem != null)
            {
                if (String.IsNullOrEmpty(address_textBox.Text) || String.IsNullOrEmpty(email_textBox.Text) || String.IsNullOrEmpty(phone_textBox.Text) || 
                    String.IsNullOrEmpty(name_textBox.Text) || String.IsNullOrEmpty(surname_textBox.Text))
                {
                    MessageBox.Show("Guncellemek istediğiniz tüm alanları doldurunuz");
                }
                else
                {
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE bank.dbo.Customer SET Name = @name, Surname = @surname, Address = @address , Phone = @phone , Email = @email  " +
                        "WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@name", name_textBox.Text);
                    cmd.Parameters.AddWithValue("@surname", surname_textBox.Text);
                    cmd.Parameters.AddWithValue("@address", address_textBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
                    cmd.Parameters.AddWithValue("@email", email_textBox.Text);
                    cmd.Parameters.AddWithValue("@id", customerList_listBox.SelectedItem.ToString());
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bilgileriniz basariyla güncellenmiştir.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                refreshTheList();
            }
            else
            {
                MessageBox.Show("Müşteri seçimi yapılmadan güncelleme işlemi yapılamaz");
            }
        }

        private void customerFinancial_button_Click(object sender, EventArgs e) // Burası düznelenecek
        {
            disableButtons();
            string gelir =".", gider=".";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(Amount) FROM Record WHERE (TransferFrom = @id)";
            cmd.Parameters.AddWithValue("@id", customerList_listBox.SelectedItem.ToString());
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    gider = reader[0].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(Amount) FROM Record WHERE (TransferTo = @id)";
            cmd.Parameters.AddWithValue("@id", customerList_listBox.SelectedItem.ToString());
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gelir = reader[0].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            float balance = 0.0f;
            // check string null 
            if (String.IsNullOrEmpty(gelir))
                gelir = "0";
            if (String.IsNullOrEmpty(gider))
                gider = "0";
            balance = float.Parse(gelir) - float.Parse(gider);
            DataTable dt = new DataTable();
            dt.Columns.Add("Gelir", typeof(string));
            dt.Columns.Add("Gider", typeof(string));
            dt.Columns.Add("Toplam Bakiye", typeof(string));
            dt.Rows.Add(gelir, gider, balance.ToString());
            customerTransaction_dataGridView.DataSource = dt;
        }

        private void customerTransactions_button_Click(object sender, EventArgs e)
        {
            disableButtons();
            ListBox lsbox = new ListBox();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT AccountNumber FROM Account WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", customerList_listBox.SelectedItem.ToString());
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lsbox.Items.Add(dr["AccountNumber"].ToString());
            }
            dr.Close();
            DataTable dt = new DataTable();
            for (int i = 0; i < lsbox.Items.Count; i++)
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT TOP (1000) * FROM Record WHERE (TransferTo = @id OR TransferFrom = @id) ORDER BY RecNum DESC";
                DateTime myDateTime = DateTime.Now;
                string date = myDateTime.ToString("yyyy-MM");
                cmd.Parameters.AddWithValue("@id", lsbox.Items[i].ToString());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                    if (i == 0)
                    {
                        da.Fill(dt);
                    }
                    else
                    {
                        DataTable tempdt = new DataTable();
                        da.Fill(tempdt);
                        dt.Merge(tempdt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            customerTransaction_dataGridView.DataSource = dt;
        }

        private void refreshCustomerDemands()
        {
            if (customerList_listBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Lutfen musteri secimi yapiniz.");
            }
            else
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Demand WHERE CustomerID = @id";
                cmd.Parameters.AddWithValue("@id", customerList_listBox.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    customerTransaction_dataGridView.DataSource = dt;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void customerRequests_button_Click(object sender, EventArgs e)
        {
            enableButtons();
            refreshCustomerDemands();
        }

        private void rejectDemand()
        {
            foreach (DataGridViewRow row in customerTransaction_dataGridView.SelectedRows)
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Demand WHERE demandNumber = @id";
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            if(customerTransaction_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim yapınız lutfen");
            }
            else
            {
                rejectDemand();
                MessageBox.Show("Talepler başarıyla reddedilmiştir.");
            }
            refreshCustomerDemands();
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            float loan = 0f;
            string[] lscell = new string[3];
            lscell[0] = customerTransaction_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            lscell[1] = customerTransaction_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            lscell[2] = customerTransaction_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            if(lscell[1] == "Kredi Talebi")
            {
                float oldLoan = 0f;
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT loan FROM Customer WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", lscell[0]);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    oldLoan = float.Parse(dr["loan"].ToString());
                }
                dr.Close();
                loan = float.Parse(lscell[2]);
                //
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ValueFloat FROM Settings WHERE sID = 6";
                float interest = 0f;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    interest = float.Parse(dr["ValueFloat"].ToString());
                }
                dr.Close();
                //
                loan += (interest * loan) / 100;
                loan = loan + oldLoan;
                //
                cmd = new SqlCommand();
                cmd.Connection=con;
                cmd.CommandText = "UPDATE Customer SET loan = @loan WHERE ID = @id";
                cmd.Parameters.AddWithValue("@loan", loan);
                cmd.Parameters.AddWithValue("@id", lscell[0]);
                cmd.ExecuteNonQuery();
                //
                cmd = new SqlCommand();
                cmd.Connection = con;
                
            }
            

            rejectDemand();
            MessageBox.Show("Talepler başarıyla onaylanmıstır.");
            refreshCustomerDemands();
        }
    }
}
