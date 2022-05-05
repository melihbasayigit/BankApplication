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
            customer_listBox.Items.Clear();
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

        private void customer_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newCustomer_button_Click(object sender, EventArgs e)
        {
            int repID = 1;
            List<repList> tempList = new List<repList>();
            con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(repID) as 'Total', repID FROM Customer GROUP BY repID";
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                repList temp = new repList(reader.GetInt32(0), reader.GetInt32(1));
                tempList.Add(temp);
            }
            // sort list function
            // get first element function = string repID;
            // ad string repID to cmd Parameters
            reader.Close();
            con.Close();
            //
            con = new SqlConnection("server=.;Initial Catalog=bank;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "INSERT INTO Customer(ID,Name,Surname,Address,Email,Phone,repID) Values(@id, @name, @surname, @address, @email, @phone, @repID)";
            cmd.Parameters.AddWithValue("@id", id_textBox.Text);
            cmd.Parameters.AddWithValue("@name", name_textBox.Text);
            cmd.Parameters.AddWithValue("@surname", surname_textBox.Text);
            cmd.Parameters.AddWithValue("@address", address_textBox.Text);
            cmd.Parameters.AddWithValue("@email", email_textBox.Text);
            cmd.Parameters.AddWithValue("@phone", phone_textBox.Text);
            cmd.Parameters.AddWithValue("@repID", repID);
            con.Open();
            reader = cmd.ExecuteReader();
            // execute non query

        }
    }
}
