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
    public partial class nasgorRecipe : Form
    {
        SqlConnection connection;
        string connstring;
        public nasgorRecipe()
        {
            InitializeComponent();

            connstring = ConfigurationManager.ConnectionStrings["DatabasePersonalPBO.Properties.Settings.RecipesConnectionString"].ConnectionString;

        }

        private void nasgorRecipe_Load(object sender, EventArgs e)
        {
            
        }
        private void PopulateList()
        {
            using (connection = new SqlConnection(connstring)) 
            using (SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from Recipe", connection))
            {
                connection.Open();
                DataTable recipeTable = new DataTable();
                adapt.Fill(recipeTable);

                NasiGorengRecipe.DisplayMember = "Name";
                NasiGorengRecipe.ValueMember = "Id";
                NasiGorengRecipe.DataSource = recipeTable;

                connection.Close();
            }
        }

        private void NasiGorengRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(NasiGorengRecipe.SelectedValue.ToString());

        }
    }
}
