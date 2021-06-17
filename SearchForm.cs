using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabasePersonalPBO
{
    public partial class SearchForm : Form
    {
        rendangRecipe rendangForm = new rendangRecipe();
        nasgorRecipe nasgorForm = new nasgorRecipe();
        recipeSoto sotoForm = new recipeSoto();
        capcayRecipe capcayForm = new capcayRecipe();
        Cookbook redirectcook = new Cookbook();
        
        public SearchForm()
        {
            InitializeComponent();
        }

        private void rendang_pic_Click(object sender, EventArgs e)
        {
            rendangForm.Show();
        }


        private void srch_btn_Click(object sender, EventArgs e)
        {
            redirectcook.Show();

        }

        private void soto_pic_Click(object sender, EventArgs e)
        {
            sotoForm.ShowDialog();
        }

        private void nasgor_pic_Click(object sender, EventArgs e)
        {
            nasgorForm.ShowDialog();
        }

        private void capcay_pic_Click(object sender, EventArgs e)
        {
            capcayForm.ShowDialog();
        }
    }
}
