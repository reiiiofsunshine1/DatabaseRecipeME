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
    public partial class Welcomepg : Form
    {
        UpSchpg redirect1 = new UpSchpg();
        public Welcomepg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.searchDBDataSet);

        }

        private void Welcomepg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'searchDBDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.searchDBDataSet.customer);

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            redirect1.Show();
        }
    }
}
