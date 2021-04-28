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
    public partial class UpSchpg : Form
    {
        UploadForm redirect22 = new UploadForm();
        SearchForm redirect21 = new SearchForm();
        public UpSchpg()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            redirect21.Show();

        }

        private void upld_btn_Click(object sender, EventArgs e)
        {
            redirect22.Show();
        }
    }
}
