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
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        bool showMainMenu = true;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //showMainMenu = false;
            //Will be needed later on
            this.Close();
        }

    }
}
