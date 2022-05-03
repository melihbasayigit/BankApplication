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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=localhost;Initial Catalog=bank;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Bağlantı başarıyla kuruldu.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı kurulamadı");
            }
        }

        private void but_customer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void but_rep_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void but_bankmanager_Click(object sender, EventArgs e)
        {
            Form4 form4 =new Form4();
            form4.ShowDialog();
        }
    }
}
