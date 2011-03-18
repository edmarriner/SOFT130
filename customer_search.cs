using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SOFT130Project
{
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch(file this_fileClass)
        {
            InitializeComponent();
            fileClass = this_fileClass;
        }

        bool showMainMenu = true;
        file fileClass;

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
            searchForCustomer();            
        }

        private void searchForCustomer()
        {
            bool addCustomerToDgv = false;
            ArrayList returnedData = fileClass.readFile();
            int currentCustomerNum = 0;
            int resultsShown = 0;

            dgvCustomers.Rows.Clear();

            foreach (Customer oneCustomer in returnedData)
            {
                
                addCustomerToDgv = false; //make this false

                if (Regex.IsMatch(oneCustomer.getfirstName(), txtSearchTerm.Text, RegexOptions.IgnoreCase))
                {
                    addCustomerToDgv = true;
                }

                if (Regex.IsMatch(oneCustomer.getsurname(), txtSearchTerm.Text, RegexOptions.IgnoreCase))
                {
                    addCustomerToDgv = true;
                }

                if (Regex.IsMatch(oneCustomer.getpostcode(), txtSearchTerm.Text, RegexOptions.IgnoreCase))
                {
                    addCustomerToDgv = true;
                }

                if (Regex.IsMatch(oneCustomer.getcityTown(), txtSearchTerm.Text, RegexOptions.IgnoreCase))
                {
                    addCustomerToDgv = true;
                }

                if (Regex.IsMatch(oneCustomer.getcounty(), txtSearchTerm.Text, RegexOptions.IgnoreCase))
                {
                    addCustomerToDgv = true;
                }

                if (addCustomerToDgv)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    DataGridViewCell dgvCell = new DataGridViewTextBoxCell();

                    dgvCell.Value = currentCustomerNum;
                    dgvRow.Cells.Add(dgvCell);

                    dgvCell = new DataGridViewTextBoxCell();
                    dgvCell.Value = oneCustomer.getfirstName() + " " + oneCustomer.getinitials() + " " + oneCustomer.getsurname();
                    dgvRow.Cells.Add(dgvCell);

                    dgvCell = new DataGridViewTextBoxCell();
                    dgvCell.Value = oneCustomer.gethouseNameNumber() + " " + oneCustomer.getstreetName() + ", " + oneCustomer.getpostcode();
                    dgvRow.Cells.Add(dgvCell);

                    dgvCustomers.Rows.Add(dgvRow);
                    resultsShown++;
                }

                currentCustomerNum++;
            }

            dgvCustomers.Refresh();

            if (resultsShown == 0)
            {
                lblResult.Text = "No results";
            }
            else if (resultsShown == 1)
            {
                lblResult.Text = "1 result";
            }
            else
            {
                lblResult.Text = resultsShown + " results";
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewCustomer();
        }

        private void txtSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                searchForCustomer();
                      
            }
        }

        private void dgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewCustomer();
        }

        private void viewCustomer()
        {
            showMainMenu = false;
            int selectedCustomer = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);

            fileClass.setcurrentCustomerNum(selectedCustomer);

            frmPasswordPrompt frmPasswordPrompt = new frmPasswordPrompt(fileClass);
            frmPasswordPrompt.Show();
            this.Close();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = "";
            searchForCustomer();
        }

    }
}
