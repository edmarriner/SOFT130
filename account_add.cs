using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

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
            tmrDateTime_Tick(sender, e);
        }

        private void validateAccountName(object sender, EventArgs e)
        {
            if (txtAccountName.Text != "")
            {
                pboAccountName.Image = new Bitmap("tick.png");
            }
            else
            {
                pboAccountName.Image = new Bitmap("cross.png");
            }
        }

        private void validateSortCode(object sender, EventArgs e)
        {
            //Only allow number entry in the sort code
            Regex intOnly = new Regex("[^0-9]");
            int currentSelection = txtSortCode1.SelectionStart;
            txtSortCode1.Text = intOnly.Replace(txtSortCode1.Text, "");
            txtSortCode1.Select(currentSelection, 0);

            currentSelection = txtSortCode2.SelectionStart;
            txtSortCode2.Text = intOnly.Replace(txtSortCode2.Text, "");
            txtSortCode2.Select(currentSelection, 0);

            currentSelection = txtSortCode3.SelectionStart;
            txtSortCode3.Text = intOnly.Replace(txtSortCode3.Text, "");
            txtSortCode3.Select(currentSelection, 0);

            //Only validate sort code if there are exactly two numbers in each box
            if (txtSortCode1.Text.Length == 2 && txtSortCode2.Text.Length == 2 && txtSortCode3.Text.Length == 2)
            {
                pboSortCode.Image = new Bitmap("tick.png");
            }
            else
            {
                pboSortCode.Image = new Bitmap("cross.png");
            }
        }

        private void validateOverdraftLimit(object sender, EventArgs e)
        {
            //Only allow number entry or periods in the overdraft limit
            Regex intOnly = new Regex("[^0-9.]");
            int currentSelection = txtOverdraftLimit.SelectionStart;
            txtOverdraftLimit.Text = intOnly.Replace(txtOverdraftLimit.Text, "");
            txtOverdraftLimit.Select(currentSelection, 0);

            if (txtOverdraftLimit.Text != "")
            {
                pboOverdraftLimit.Image = new Bitmap("tick.png");
            }
            else
            {
                pboOverdraftLimit.Image = new Bitmap("cross.png");
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime CurrTime = DateTime.Now;
            lblDate.Text = CurrTime.ToString("D");
            lblTime.Text = CurrTime.ToString("hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
