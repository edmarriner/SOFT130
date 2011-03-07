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

        bool showMainMenu = true;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frmTransactionAdd frmTransactionAdd = new frmTransactionAdd();
            frmTransactionAdd.Show();
            showMainMenu = false;
            this.Close();
        }

        private void frmAccountAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

        private void frmAccountAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
