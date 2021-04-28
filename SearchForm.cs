using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasePersonalPBO
{
    public partial class SearchForm : Form
    {
        Cookbook redirectcook = new Cookbook();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void rendang_pic_Click(object sender, EventArgs e)
        {
            
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            redirectcook.Show();

        }
    }
}
