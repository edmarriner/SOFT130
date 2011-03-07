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
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAccountAdd frmAccountAdd = new frmAccountAdd();
            frmAccountAdd.Show();
            this.Close();
        }
    }
}
