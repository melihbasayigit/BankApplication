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
            try
            {
                cnn.Open();
                //cnn.Close();
            }
            catch (Exception ex)
            {
                loginStatus_label.Text = "Veritabanına bağlanmada sıkıntı çıktı. Lütfen daha sonra tekrar deneyin.";
            }
            // Giriş kontrol 
            loginCmd = new SqlCommand();
            loginCmd.Connection = cnn;
            loginCmd.CommandText = "SELECT CurrencyName FROM Currency";
            loginDr = loginCmd.ExecuteReader();
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
            cnn.Close();
        }

    }
}
