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
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Name, Surname FROM Customer";
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                customer_listBox.Items.Add(reader["Name"] + " " + reader["Surname"]);
            }
            reader.Close();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            //customer_listBox.Items.Clear();
            con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Name, Surname FROM Customer";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customer_listBox.Items.Add(reader["Name"] + " " + reader["Surname"]);
            }
            reader.Close();
            con.Close();
        }
    }
}
