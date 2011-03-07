using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SOFT130Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime CurrTime = DateTime.Now;
            lblDate.Text = CurrTime.ToString("D");
            lblTime.Text = CurrTime.ToString("hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            tmrDateTime_Tick(sender, e);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerAdd frmCustomerAdd = new frmCustomerAdd();
            frmCustomerAdd.Show();
            this.Close();
        }

    }
}
