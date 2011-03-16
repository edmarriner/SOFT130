using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOFT130Project
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView(file this_fileClass)
        {
            InitializeComponent();
            fileClass = this_fileClass;
        }

        bool showMainMenu = true;
        file fileClass;

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            
            int currentCustomerNum = fileClass.getcurrentCustomerNum();
            int currentAccountNum = 0;
            ArrayList returnedData = fileClass.readFile();

            Customer thisCustomer = (Customer) returnedData[currentCustomerNum];

            lblCustomerName.Text = thisCustomer.getfirstName() + " " + thisCustomer.getsurname();
            lblCustomerDOB.Text = thisCustomer.getdob();
            lblCustomerHouseNameOrNum.Text = thisCustomer.gethouseNameNumber();
            lblCustomerStreet.Text = thisCustomer.getstreetName();
            lblCustomerAddress.Text = thisCustomer.getaddressArea();
            lblCustomerTownOrCity.Text = thisCustomer.getcityTown();
            lblCustomerCounty.Text = thisCustomer.getcounty();
            lblCustomerPostcode.Text = thisCustomer.getpostcode();

            foreach (Account oneAccount in thisCustomer.getaccountList())
            {

                DataGridViewRow dgvRow = new DataGridViewRow();
                DataGridViewCell dgvCell = new DataGridViewTextBoxCell();

                dgvCell.Value = currentAccountNum;
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneAccount.getnickName();
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = oneAccount.getcurrentBalance();
                dgvRow.Cells.Add(dgvCell);

                dgvAccounts.Rows.Add(dgvRow);
                currentAccountNum++;
            }


        }

        private void frmCustomerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

       


    }
}
