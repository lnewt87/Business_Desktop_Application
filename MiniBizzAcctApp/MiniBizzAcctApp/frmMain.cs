using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBizzAcctApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void closeAllWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }

        private void toolStripBtnProduction_Click(object sender, EventArgs e)
        {
            Form newForm = new frmProduction();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to really quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to really quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void toolStripBtnCustomer_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCustomerMaintenance();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void toolStripBtnExpense_Click(object sender, EventArgs e)
        {
            Form newForm1 = new frmExpenseMaintenance(); 
            newForm1.MdiParent = this;
            newForm1.Show();
        }

        private void toolStripBtnInventory_Click(object sender, EventArgs e)
        {
            Form newForm = new frmInventoryMaintenance();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
