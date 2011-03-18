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
    public partial class frmAccountView : Form
    {
        public frmAccountView(file this_fileClass)
        {
            InitializeComponent();
            fileClass = this_fileClass;
        }

        bool showMainMenu = true;
        file fileClass;

        private void frmAccountView_Load(object sender, EventArgs e)
        {
            tmrDateTime_Tick(sender, e);
            int currentCustomerNum = fileClass.getcurrentCustomerNum();
            int currentAccountNum = fileClass.getcurrentAccountNum();
            int currentTransactionNum = 0;
            ArrayList returnedData = fileClass.readFile();

            Customer thisCustomer = (Customer) returnedData[currentCustomerNum];
            ArrayList accountList = thisCustomer.getaccountList();
            Account thisAccount = (Account) accountList[currentAccountNum];

            lblCustomer.Text = thisCustomer.getfirstName() + " " + thisCustomer.getsurname() + " - " + thisCustomer.getpostcode();
            lblAccountNickName.Text = thisAccount.getnickName();
            lblAccountNumber.Text = Convert.ToString(thisAccount.getaccountNumber());
            lblAccountSortCode.Text = thisAccount.getsortCode();
            lblAccountBalance.Text = String.Format("{0:c}", thisAccount.getcurrentBalance());

            foreach (Transaction oneTransaction in thisAccount.gettransactionList())
            {

                DataGridViewRow dgvRow = new DataGridViewRow();
                DataGridViewCell dgvCell = new DataGridViewTextBoxCell();

                dgvCell.Value = currentTransactionNum;
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneTransaction.getdate();
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneTransaction.gettype();
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneTransaction.getdescription();
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneTransaction.getamount();
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneTransaction.getbalanceAfter();
                dgvRow.Cells.Add(dgvCell);

                dgvTransactions.Rows.Add(dgvRow);
                currentTransactionNum++;
            }

            dgvTransactions.Refresh();

        }

        private void frmAccountView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime CurrTime = DateTime.Now;
            lblDate.Text = CurrTime.ToString("D");
            lblTime.Text = CurrTime.ToString("hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
        }


       
    }
}
