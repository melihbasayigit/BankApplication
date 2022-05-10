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
            //cnn.Close();
        }

        private void Acc_listbox_SelectedValueChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
