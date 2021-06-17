using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabasePersonalPBO
{
    public partial class Welcome_Form : Form
    {
        string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vscode\databasepbo\DatabasePersonalPBO\DatabasePersonalPBO\Recipes.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        UpSchpg redirect1 = new UpSchpg();
        public Welcome_Form()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void submit_btn_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vscode\databasepbo\DatabasePersonalPBO\DatabasePersonalPBO\Recipes.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Customer (Nama, Address, Phone, Email) VALUES (@Nama, @Address, @Phone, @Email)", con);
            cmd.Parameters.Add("@Nama", tbName.Text);
            cmd.Parameters.Add("@Address", tbAddress.Text);
            cmd.Parameters.Add("@Phone", tbPhone.Text);
            cmd.Parameters.Add("@Email", tbEmail.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            display();
            clear();
        }

        private void cont_btn_Click(object sender, EventArgs e)
        {
            redirect1.ShowDialog();
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Customer", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }
    }
}
