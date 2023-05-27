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

namespace DB_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM products WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = txtB_name_update.Text;
            string sale = txtB_update_sale.Text;
            string buy = txtB_update_buy.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE products SET sale_price='" + sale + "',buy_price='" + buy + "' WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Changes have been saved!!!!");
            txtB_name_update.Text = txtB_update_buy.Text = txtB_update_sale.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = tB_name.Text;
            string sale = tB_sale.Text;
            string buy = tB_buy.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO products (name,sale_price,buy_price) VALUES ('" + name + "','" + sale + "','" + buy + "')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Changes have been saved!!!!");
            tB_name.Text = tB_sale.Text = tB_buy.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\DB_Example\DB_Example\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT name FROM products";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                comboBox1.Items.Add(name);
            }

            sc.Close();
        }
    }
}
