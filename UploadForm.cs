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
    public partial class UploadForm : Form
    {
        string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vscode\databasepbo\DatabasePersonalPBO\DatabasePersonalPBO\Recipes.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

       
        public UploadForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();

        }


        

        private void UploadForm_Load(object sender, EventArgs e)
        {
            

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vscode\databasepbo\DatabasePersonalPBO\DatabasePersonalPBO\Recipes.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Upload (Namee, recName1, recName2, recName3, recName4, recName5, recName6, recName7, recName8, recName9, recName10) VALUES " +
                "(@Namee, @recName1, @recName2, @recName3, @recName4, @recName5, @recName6, @recName7, @recName8, @recName9, @recName10)", con);
            cmd.Parameters.Add("@Namee", recipeNameTextBox.Text);
            cmd.Parameters.Add("@recName1", ing1TextBox.Text);
            cmd.Parameters.Add("@recName2", ing2TextBox.Text);
            cmd.Parameters.Add("@recName3", ing3TextBox.Text);
            cmd.Parameters.Add("@recName4", ing4TextBox.Text);
            cmd.Parameters.Add("@recName5", ing5TextBox.Text);
            cmd.Parameters.Add("@recName6", ing6TextBox.Text);
            cmd.Parameters.Add("@recName7", ing7TextBox.Text);
            cmd.Parameters.Add("@recName8", ing8TextBox.Text);
            cmd.Parameters.Add("@recName9", ing9TextBox.Text);
            cmd.Parameters.Add("@recName10", ing10TextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            display();
            clear();
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Upload", con);
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            recipeNameTextBox.Text = "";
            ing1TextBox.Text = "";
            ing2TextBox.Text = "";
            ing3TextBox.Text = "";
            ing4TextBox.Text = "";
            ing5TextBox.Text = "";
            ing6TextBox.Text = "";
            ing7TextBox.Text = "";
            ing8TextBox.Text = "";
            ing9TextBox.Text = "";
            ing10TextBox.Text = "";

        }
    }
}
