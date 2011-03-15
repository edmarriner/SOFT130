using System;
using System.Collections.Generic;
using System.Collections;
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

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustomerSearch = new frmCustomerSearch();
            frmCustomerSearch.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ArrayList returnedData = fileHandling.readFile();

            foreach (Customer oneCustomer in returnedData)
            {
                textBox1.Text += "Customer: " + oneCustomer.getfirstName() + " " + oneCustomer.getsurname() + Environment.NewLine;

                foreach (Account oneAccount in oneCustomer.getaccountList())
                {
                    textBox1.Text += "     Account: " + oneAccount.getaccountNumber() + " (" + oneAccount.getnickName() + ") " + Environment.NewLine;

                    foreach (Transaction oneTransaction in oneAccount.gettransactionList())
                    {
                        textBox1.Text += "          Transaction: " + oneTransaction.getdescription() + " " + String.Format("{0:c}", oneTransaction.getamount()) + Environment.NewLine;
                    }

                }

            }

          

            //textBox1.Text = returnedData;
        }

    }
}
