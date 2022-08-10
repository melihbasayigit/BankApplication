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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
            con.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refreshTheList()
        {
            currency_listBox.Items.Clear();
            con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "SELECT ValueFloat FROM Settings WHERE sID>4 AND sID<8";
            List<string> settingValues = new List<string>(3);
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {

                settingValues.Add(reader["ValueFloat"].ToString());
            }
            reader.Close();
            interestRatio_textBox.Text = settingValues[1];
            overdueInterest_textBox.Text = settingValues[2];
            salary_textBox.Text = settingValues[0];
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT CurrencyName FROM Currency";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                currency_listBox.Items.Add(reader["CurrencyName"]);
            }
            reader.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            refreshTheList();
        }

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool checkAddCustomerBoxes()
        {
            if(String.IsNullOrEmpty(id_textBox.Text) || String.IsNullOrEmpty(name_textBox.Text) || String.IsNullOrEmpty(surname_textBox.Text) || 
                String.IsNullOrEmpty(address_textBox.Text) || String.IsNullOrEmpty(phone_textBox.Text) || String.IsNullOrEmpty(email_textBox.Text))
                return false;
            return true;
        }

        private void newCustomer_button_Click(object sender, EventArgs e) // Düzenle
        {
            if(checkAddCustomerBoxes() == true)
            {
                int retunrRepID = 201;
                List<repList> tempList = new List<repList>();
                con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT COUNT(repID) as 'Total', repID FROM Customer GROUP BY repID";
                con.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    repList temp = new repList(Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()));
                    tempList.Add(temp);
                }
                // sort list function
                // get first element function = int repID;
                // ad string repID to cmd Parameters
                reader.Close();
                for (int i = 0; i < tempList.Count; i++)
                {
                    for (int j = 1; j < tempList.Count; j++)
                    {
                        if(tempList[i].repCount > tempList[j].repCount)
                        {
                            repList temp = new repList(tempList[i].repCount, tempList[i].repID);
                            tempList[i].repCount = tempList[j].repCount;
                            tempList[i].repID = tempList[j].repID;
                            tempList[j].repID = temp.repID;
                            tempList[j].repCount = temp.repCount;
                        }
                    }
                }
                retunrRepID = tempList[0].returnRepID();
                //
                
                // execute non query
                con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Customer(ID,Name,Surname,Address,Email,Phone,repID, loan) Values(@id, @name, @surname, @address, @email, @phone, @repID, 0)";
                cmd.Parameters.AddWithValue("@id", id_textBox.Text);
                cmd.Parameters.AddWithValue("@name", name_textBox.Text);
                cmd.Parameters.AddWithValue("@surname", surname_textBox.Text);
                cmd.Parameters.AddWithValue("@address", address_textBox.Text);
                cmd.Parameters.AddWithValue("@email", email_textBox.Text);
                cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
                cmd.Parameters.AddWithValue("@repID", retunrRepID.ToString());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme sırasında hata oluştu: " + ex.Message);
                }
                //
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO bank.dbo.Account(ID, CurCode, Balance) Values(@id, 'TUR', 0)";
                cmd.Parameters.AddWithValue("@id", id_textBox.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ekleme işlemi başarıyla tamamlandı.");
                    id_textBox.Clear();
                    name_textBox.Clear();
                    address_textBox.Clear();
                    email_textBox.Clear();
                    phone_textBox.Clear();
                    surname_textBox.Clear();
                    refreshTheList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lutfen tum gerekli alanları doldurunuz");
            }
        }

        private void currencyCode_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        string currencyName_selected;
        private void currency_listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(currency_listBox.SelectedItem != null)
            {
                currencyName_selected = currency_listBox.SelectedItem.ToString();
                con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
                cmd = new SqlCommand();
                cmd.CommandText = "SELECT Value FROM Currency WHERE CurrencyName = @name";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@name", currencyName_selected);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currencyUpdValue_textBox.Text = reader["Value"].ToString();
                }
                reader.Close();
            }
        }

        private void addCurrency_button_Click(object sender, EventArgs e) // BURAYI DUZENLE DUZGUN CALSIMIYOR
        {
            if (String.IsNullOrEmpty(currencyCode_textBox.Text) || String.IsNullOrEmpty(currencyAddValue_textBox.Text) || String.IsNullOrEmpty(currencyAddName_textBox.Text) ||
                currencyCode_textBox.Text.Length != 3)
            {
                MessageBox.Show("Lutfen tum alanlari doğru şekilde doldurunuz.");
            }
            else
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Currency(CurCode,CurrencyName,Value) Values(@curCode, @currencyName, @Value)";
                cmd.Parameters.AddWithValue("@curCode", currencyCode_textBox.Text);
                cmd.Parameters.AddWithValue("@Value", currencyAddValue_textBox.Text);
                cmd.Parameters.AddWithValue("@currencyName", currencyAddName_textBox.Text);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    cmd.ExecuteReader();
                    MessageBox.Show("Başarıyla eklendi");
                    refreshTheList();
                    currencyCode_textBox.Clear();
                    currencyAddName_textBox.Clear();
                    currencyAddValue_textBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                reader.Close();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string info = ".";
            if(!String.IsNullOrEmpty(interestRatio_textBox.Text))
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE bank.dbo.Settings SET ValueFloat = @value WHERE sID = 6";
                cmd.Parameters.AddWithValue("@value", interestRatio_textBox.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    info = "Faiz Oranı\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (!String.IsNullOrEmpty(overdueInterest_textBox.Text))
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE bank.dbo.Settings SET ValueFloat = @value WHERE sID = 7";
                cmd.Parameters.AddWithValue("@value", overdueInterest_textBox.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    info = info + "Kredi Faiz Oranı\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (!String.IsNullOrEmpty(salary_textBox.Text))
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE bank.dbo.Settings SET ValueFloat = @value WHERE sID = 5";
                cmd.Parameters.AddWithValue("@value", salary_textBox.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    info = info + "Çalışan Maaşı\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (!String.IsNullOrEmpty(currencyUpdValue_textBox.Text))
            {
                if(currency_listBox.SelectedItem != null) // burayı duznele
                {
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE bank.dbo.Currency SET Value = @value  WHERE CurrencyName = @currencyName";
                    cmd.Parameters.AddWithValue("@value", currencyUpdValue_textBox.Text);
                    cmd.Parameters.AddWithValue("@currencyName", currency_listBox.SelectedItem.ToString());
                    try
                    {
                        cmd.ExecuteNonQuery();
                        info = info + currency_listBox.SelectedItem.ToString() + " Kur Oranı\n";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Guncelleme islemleri: \n" + info);
        }

        private void listAction_button_Click(object sender, EventArgs e)
        {
            int number = 1;
            number = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TOP (@last) * FROM Record ORDER BY RecNum DESC";
            cmd.Parameters.AddWithValue("@last", number);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                allTransaction_dataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deadlock_button_Click(object sender, EventArgs e)
        {
            int number = 1;
            number = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            listAction_button_Click(sender, new EventArgs());
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TOP (@last) * FROM Record ORDER BY RecNum DESC";
            cmd.Parameters.AddWithValue("@last", number);
            List<deadlockItem> deadlockList = new List<deadlockItem>();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int recNum = Int32.Parse(reader["RecNum"].ToString());
                    int to;
                    int from;
                    if (!reader.IsDBNull(1))
                    {
                        from = Int32.Parse(reader["TransferFrom"].ToString());
                    }
                    else
                    {
                        from = 0; // 0 is the bank or NULL value.
                    }
                    if (!reader.IsDBNull(2))
                    {
                        to = Int32.Parse(reader["TransferTo"].ToString());
                    }
                    else
                    {
                        to = 0; // 0 is the bank or NULL value.
                    }
                    string type = reader["RecType"].ToString();
                    deadlockItem tempDeadlock = new deadlockItem(recNum, from, to, type);
                    deadlockList.Add(tempDeadlock);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            List<String> deadlockOutput = new List<string>();
            for (int i = 0; i < deadlockList.Count; i++)
            {
                if (deadlockList[i].type != "Para Gönderme")
                {
                    deadlockList.RemoveAt(i);
                    i--;
                }
            }
            List<deadlockItem> deadlockList2 = new List<deadlockItem>();
            for (int i = deadlockList.Count -1; i >= 0 ; i--)
            {
                deadlockList2.Add(deadlockList[i]);   
            }
            deadlockList = deadlockList2;

            // Deadlock Analzye

            while (deadlockList.Count > 0)
            {
                List<int> numbers = new List<int>();
                int target = deadlockList[0].to;
                numbers.Add(deadlockList[0].recNum);
                for (int i = 1; i < deadlockList.Count; i++)
                {
                    if (deadlockList[i].to == target || deadlockList[i].from == target)
                    {
                        int index = i - 1;
                        numbers.Add(deadlockList[i].recNum);
                        deadlockList.RemoveAt(i);
                        i = index;
                    }
                }
                deadlockList.RemoveAt(0);
                if(numbers.Count >= 2)
                {
                    string tempStr = "(" + numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        tempStr += "-" + numbers[i];
                    }
                    tempStr += ")";
                    deadlockOutput.Add(tempStr);
                }
            }
            MessageBox.Show("Number of Deadlock: " + deadlockOutput.Count.ToString());
            for (int i = 0; i < deadlockOutput.Count; i++)
            {
                MessageBox.Show(deadlockOutput[i]);
            }

        }
    }
}
