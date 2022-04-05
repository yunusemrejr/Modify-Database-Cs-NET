using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Modify_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

             string sql = "SELECT * FROM users";
            MySqlConnection con = new MySqlConnection("user=root;password=pass;server=localhost;port=3306;database=random");
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "random");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "random";




        }

         public void DataGridView1()
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=pass;database=random";
                string Query = "INSERT INTO users VALUES ("+ this.textBoxID.Text+",'"+this.textBoxNAME.Text + "','"+ this.textBoxSURNAME.Text+"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("User Added Successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! We have a problem! ERROR message: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=pass";
                string Query = "delete from random.users where ID='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("User Deleted Successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! We have a problem! ERROR message: "+ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=pass;database=random";
                string Query = "UPDATE users SET firstname = '" + this.textBox3.Text + "' WHERE ID = " + this.textBox4.Text + ";" + "UPDATE users SET surname = '"+ this.textBox2.Text + "' WHERE ID = " + this.textBox4.Text + ";" ;
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("User Added Successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh no! We have a problem! ERROR message: " + ex.Message);
            }
        }
    }
}
