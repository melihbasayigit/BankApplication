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
                    cmd.CommandText = "SELECT Name, Surname FROM Worker WHERE ID = @WorkerID"; // add here sql command for to list all customers belong to the representative
                    cmd.Parameters.Add("@WorkerID", SqlDbType.Int);
                    cmd.Parameters["@WorkerID"].Value = id_textBox.Text;
                    cmd.Prepare();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        customerList_listBox.Items.Add(dr["Name"] + " " + dr["Surname"]);

                    }
                }
                if (customerList_listBox.Items.Count == 0)
                {
                    isLogin = false;
                    MessageBox.Show("Giris yapılamadı.");
                }
                else
                {
                    isLogin = true;
                    idStatus_label.Visible = true;
                    idStatus_label.Text = id_textBox.Text;
                    idStatus_label.ForeColor = Color.DarkBlue;
                    loginStatus_label.Text = "Başarılı bir şekilde giriş yaptınız.";
                    loginStatus_label.ForeColor = Color.Green;
                }
            }
            
        }

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
            
        }

        private void customerList_listBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
