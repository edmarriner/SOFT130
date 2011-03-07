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
    public partial class frmAccountAdd : Form
    {
        public frmAccountAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frmTransactionAdd frmTransactionAdd = new frmTransactionAdd();
            frmTransactionAdd.Show();
            this.Close();
        }
    }
}
