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
    public partial class rendangRecipe : Form
    {
        string connstring;
        SqlConnection con;

        public rendangRecipe()
        {
            InitializeComponent();
        }

        private void recipexIngredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipexIngredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recipesDataSet);

        }

        private void rendangRecipe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipesDataSet.RecipexIngredient' table. You can move, or remove it, as needed.
            this.recipexIngredientTableAdapter.Fill(this.recipesDataSet.RecipexIngredient);

        }

        private void listRendang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
