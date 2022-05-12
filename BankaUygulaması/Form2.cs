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
    public partial class Form2 : Form
    {
        SqlConnection cnn;
        SqlCommand loginCmd;
        SqlDataReader loginDr;
        string connectionString;
        public float interestRatio = 0f;
        string[] splitted;
        public Form2()
        {
            InitializeComponent();
            interestRatio_label.Text = "Faiz Oranı: %";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // Veritabanı kontrol işlemleri
            connectionString = @"Data Source=localhost;Initial Catalog=bank;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            // Giriş kontrol 
            loginCmd = new SqlCommand();
            loginCmd.Connection = cnn;
            loginCmd.CommandText = "SELECT * FROM Customer WHERE ID = @customerID";
            loginCmd.Parameters.AddWithValue("@customerID",customerID_textBox.Text);
            try
            {
                cnn.Open();
                loginDr = loginCmd.ExecuteReader();
                if(loginDr.Read())
                {
                    loginStatus_label.ForeColor = System.Drawing.Color.Green;
                    loginStatus_label.Text = loginDr["Name"].ToString() + " " + loginDr["Surname"].ToString();
                    address_textBox.Text = loginDr["Address"].ToString();
                    phone_textBox.Text = loginDr["Phone"].ToString();
                    email_textBox.Text = loginDr["Email"].ToString();
                    login_button.Enabled = false;
                    customerID_textBox.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Veritabanından veri çekilemedi.");
                }
            }
            catch   (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            loginDr.Close();
            // 
            loginCmd = new SqlCommand();
            loginCmd.Connection = cnn;
            loginCmd.CommandText = "SELECT * FROM Account WHERE ID = @customerID";
            loginCmd.Parameters.AddWithValue("@customerID", customerID_textBox.Text);
            try
            {
                loginDr = loginCmd.ExecuteReader();
                deleteAcc_listBox.Items.Clear();
                Acc_listbox.Items.Clear();
                while( loginDr.Read())
                {
                    Acc_listbox.Items.Add(loginDr["AccountNumber"].ToString() + "_" + loginDr["CurCode"].ToString());
                    deleteAcc_listBox.Items.Add(loginDr["AccountNumber"].ToString() + "_" + loginDr["CurCode"].ToString());
                }
                loginDr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            //
            loginCmd = new SqlCommand();
            loginCmd.Connection = cnn;
            loginCmd.CommandText = "SELECT CurrencyName FROM Currency";
            loginDr = loginCmd.ExecuteReader();
            createAcc_listBox.Items.Clear();
            while (loginDr.Read())
            {
                createAcc_listBox.Items.Add(loginDr["CurrencyName"]);
            }
            loginDr.Close();
            // Kredi faiz oranının veri tabanından çekilmesi ve programa yazım işlemi
            SqlCommand settingsCmd;
            settingsCmd = new SqlCommand();
            settingsCmd.Connection = cnn;
            settingsCmd.CommandText = "SELECT ValueFloat FROM Settings WHERE sID = 6";
            SqlDataReader settingsDr;
            settingsDr = settingsCmd.ExecuteReader();
            if (settingsDr.Read())
            {
                interestRatio_label.Text = "Faiz Oranı: %\n" + settingsDr["ValueFloat"].ToString();
            }
            loginDr.Close();
            settingsDr.Close();
            //cnn.Close();
        }

        private string getAccountNumber()
        {
            string[] words;
            words = Acc_listbox.SelectedItem.ToString().Split('_');
            return words[0];
        }

        private void refreshAccList()
        {
            if (Acc_listbox.SelectedItem != null)
            {
                splitted = Acc_listbox.SelectedItem.ToString().Split('_');
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT Balance, CurCode FROM Account WHERE AccountNumber = @value";
                cmd.Parameters.AddWithValue("@value", splitted[0]);
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        balance_label.Text = "Bakiye: " + (float.Parse(dr["Balance"].ToString())).ToString("0.00") + " " + dr["CurCode"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
                dr.Close();
            }
        }

        private void Acc_listbox_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshAccList();
        }

        private void customerID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(transferMoney_textBox.Text) && Acc_listbox.SelectedItem != null)
            {
                float balance = 0f;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandText = "SELECT Balance FROM Account WHERE AccountNumber = @accNumber";
                cmd.Connection=cnn;
                splitted = Acc_listbox.SelectedItem.ToString().Split('_');
                cmd.Parameters.AddWithValue("@accNumber", splitted[0]);
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        balance = float.Parse(dr["Balance"].ToString());
                    }
                    dr.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //
                float transferMoney = 0f;
                transferMoney = float.Parse(transferMoney_textBox.Text);
                if(balance < transferMoney)
                {
                    transferMoney = balance;
                }
                balance = balance - transferMoney;
                //
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "UPDATE bank.dbo.Account SET Balance = @money WHERE AccountNumber = @accNumber";
                cmd.Parameters.AddWithValue("@money", balance);
                cmd.Parameters.AddWithValue("@accNumber", getAccountNumber());
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İşlem tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                SqlCommand command = new SqlCommand();
                command.Connection = cnn;
                command.CommandText = "INSERT INTO Record(TransferFrom, RecType,Amount,FromBalance,Date) Values(@id, 'Para Çekme', " +
                    "@amount, @frombalance, @date)";
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@frombalance", (balance + transferMoney));
                command.Parameters.AddWithValue("@amount", transferMoney);
                command.Parameters.AddWithValue("@id", customerID_textBox.Text);
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refreshAccList();
                refreshAccList();
            }
            else
            {
                MessageBox.Show("Lutfen miktar alanını doldurun");
            }
            
        }

        private void updateMyInfo_button_Click(object sender, EventArgs e)
        {
            if(customerID_textBox.ReadOnly == true)
            {
                if(String.IsNullOrEmpty(address_textBox.Text) || String.IsNullOrEmpty(email_textBox.Text) || String.IsNullOrEmpty(phone_textBox.Text))
                {
                    MessageBox.Show("Guncellemek istediğiniz tüm alanları doldurunuz");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = "UPDATE bank.dbo.Customer SET Address = @address , Phone = @phone , Email = @email  WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@address", address_textBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
                    cmd.Parameters.AddWithValue("@email", email_textBox.Text);
                    cmd.Parameters.AddWithValue("@id", customerID_textBox.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bilgileriniz basariyla güncellenmiştir.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Giriş yapmadan duzenleme yapılmaz");
            }
        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(transferMoney_textBox.Text) && Acc_listbox.SelectedItem != null)
            {
                float balance = 0f;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandText = "SELECT Balance FROM Account WHERE AccountNumber = @accNumber";
                cmd.Connection = cnn;
                splitted = Acc_listbox.SelectedItem.ToString().Split('_');
                cmd.Parameters.AddWithValue("@accNumber", splitted[0]);
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        balance = float.Parse(dr["Balance"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //
                float transferMoney = 0f;
                transferMoney = float.Parse(transferMoney_textBox.Text);
                balance = balance + transferMoney;
                //
                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "UPDATE bank.dbo.Account SET Balance = @money WHERE AccountNumber = @accNumber";
                cmd.Parameters.AddWithValue("@money", balance);
                cmd.Parameters.AddWithValue("@accNumber", getAccountNumber());
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İşlem tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //add this to record
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                SqlCommand command = new SqlCommand();
                command.Connection = cnn;
                command.CommandText = "INSERT INTO Record(TransferTo ,RecType,Amount,ToBalance,Date) Values(@id, 'Para Yatır', " +
                    "@amount, @tobalance, @date)";
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@tobalance", (balance - transferMoney));
                command.Parameters.AddWithValue("@amount", transferMoney);
                command.Parameters.AddWithValue("@id", customerID_textBox.Text);
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refreshAccList();
            }
            else
            {
                MessageBox.Show("Lutfen miktar alanını doldurun");
            }
        }

        private void monthly_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Record WHERE (TransferTo = @id OR TransferFrom = @id) AND date >= @date1 AND Date <= @date2";
            DateTime myDateTime = DateTime.Now;
            string date = myDateTime.ToString("yyyy-MM");
            cmd.Parameters.AddWithValue("@id", customerID_textBox.Text);
            cmd.Parameters.AddWithValue("@date1", date + "-01");
            cmd.Parameters.AddWithValue("@date2", date + "-31");
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                customer_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createAcc_button_Click(object sender, EventArgs e)
        {
            if(createAcc_listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account type");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO Demand(customerID, demandType, valueString) VALUES(@id, 'Hesap Açma', @value)";
                cmd.Parameters.AddWithValue("@id", customerID_textBox.Text);
                cmd.Parameters.AddWithValue("@value", createAcc_listBox.SelectedItem.ToString());
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap açma talebiniz alınmıştır.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteAcc_button_Click(object sender, EventArgs e)
        {
            if (deleteAcc_listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account type");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO Demand(customerID, demandType, valueString) VALUES(@id, 'Hesap Silme', @value)";
                cmd.Parameters.AddWithValue("@id", customerID_textBox.Text);
                splitted = deleteAcc_listBox.SelectedItem.ToString().Split('_');
                cmd.Parameters.AddWithValue("@value", splitted[0]);
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap silme talebiniz alınmıştır.");
                    refreshAccList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void takeLoan_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(credit_textBox.Text))
            {
                MessageBox.Show("İstediğiniz kredi miktarını giriniz.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO Demand(customerID, demandType, valueFloat) VALUES(@id, 'Kredi Talebi', @value)";
                cmd.Parameters.AddWithValue("@id", customerID_textBox.Text);
                cmd.Parameters.AddWithValue("@value", credit_textBox.Text);
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kredi talebiniz alınmıştır.");
                    refreshAccList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
