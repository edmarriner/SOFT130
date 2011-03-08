using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOFT130Project
{
    public partial class frmTransactionAdd : Form
    {
        public frmTransactionAdd()
        {
            InitializeComponent();
        }

        bool showMainMenu = true;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not really sure where to send the user here...");
            //showMainMenu = false;
            //Will be needed later...
            this.Close();
        }

        private void frmTransactionAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

        private void frmTransactionAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
