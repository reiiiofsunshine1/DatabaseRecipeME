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
    public partial class Cookbook : Form
    {
        SqlConnection connection;
        string connectionString;
        public Cookbook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DatabasePersonalPBO.Properties.Settings.searchDBConnString"].ConnectionString;
        }

        private void Cookbook_Load(object sender, EventArgs e)
        {
            popRecipe();
        }
        private void popRecipe()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from  Recipe", connection))
            using (connection = new SqlConnection(connectionString))
            {
                DataTable recipeTable = new DataTable();

                listRCP.DisplayMember = "recipeName";
                listRCP.ValueMember = "Id";
                listRCP.DataSource = recipeTable;
            }
        }
        private void listRCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listRCP.SelectedValue.ToString());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
