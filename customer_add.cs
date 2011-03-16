using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SOFT130Project
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd(file this_fileClass)
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAccountAdd frmAccountAdd = new frmAccountAdd();
            frmAccountAdd.Show();
            showMainMenu = false;
            this.Close();

        }

        private void frmCustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (showMainMenu)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            cboDoBMM.SelectedIndex = 0;
            cboTitle.SelectedIndex = 0;
            cboCounty.SelectedIndex = 22;
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void validateFirstName(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                pboFirstName.Image = new Bitmap("tick.png");
            }
            else
            {
                pboFirstName.Image = new Bitmap("cross.png");
            }
        }

        private void validateSurname(object sender, EventArgs e)
        {
            if (txtSurname.Text != "")
            {
                pboSurname.Image = new Bitmap("tick.png");
            }
            else
            {
                pboSurname.Image = new Bitmap("cross.png");
            }
        }

        private void validateNumberName(object sender, EventArgs e)
        {
            if (txtNumberName.Text != "")
            {
                pboNumberName.Image = new Bitmap("tick.png");
            }
            else
            {
                pboNumberName.Image = new Bitmap("cross.png");
            }
        }

        private void validateStreetName(object sender, EventArgs e)
        {
            if (txtStreetName.Text != "")
            {
                pboStreetName.Image = new Bitmap("tick.png");
            }
            else
            {
                pboStreetName.Image = new Bitmap("cross.png");
            }
        }

        private void validateCityTown(object sender, EventArgs e)
        {
            if (txtCityTown.Text != "")
            {
                pboCityTown.Image = new Bitmap("tick.png");
            }
            else
            {
                pboCityTown.Image = new Bitmap("cross.png");
            }
        }

        private void validatePostcode(object sender, EventArgs e)
        {
            int currentSelection;
            currentSelection = txtPostcode.SelectionStart;
            txtPostcode.Text = (txtPostcode.Text).ToString().ToUpper();

            Regex alphaNumericOnly = new Regex("[^A-Z0-9]");
            txtPostcode.Text = alphaNumericOnly.Replace(txtPostcode.Text, "");

            txtPostcode.Select(currentSelection, 0);
            Regex postcodePattern = new Regex("^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]{1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$");
            if (postcodePattern.IsMatch(txtPostcode.Text))
            {
                pboPostcode.Image = new Bitmap("tick.png");
            }
            else
            {
                pboPostcode.Image = new Bitmap("cross.png");
            }
        }

        private void validatePassword(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 8)
            {
                pboPassword.Image = new Bitmap("tick.png");
            }
            else
            {
                pboPassword.Image = new Bitmap("cross.png");
            }
        }

        private void frmCustomerAdd_Activated(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void validateDoB(object sender, EventArgs e)
        {

            Regex intOnly = new Regex("[^0-9]");
            int currentSelection = txtDoBDD.SelectionStart;
            txtDoBDD.Text = intOnly.Replace(txtDoBDD.Text, "");
            txtDoBDD.Select(currentSelection, 0);
            currentSelection = txtDoBYYYY.SelectionStart;
            txtDoBYYYY.Text = intOnly.Replace(txtDoBYYYY.Text, "");
            txtDoBYYYY.Select(currentSelection, 0);

            DateTime Temp;
            string dateWhole;
            bool passed = false;
            dateWhole = txtDoBDD.Text + "/" + (Convert.ToInt32(cboDoBMM.SelectedIndex)+1) + "/" + txtDoBYYYY.Text;

            if (DateTime.TryParse(dateWhole, out Temp) == true)
            {
                passed = true;
            }

            try
            {
                int yearInt = Convert.ToInt32(txtDoBYYYY.Text);
                if (yearInt > 1850 && yearInt <= DateTime.Now.Year)
                {
                    passed = true;
                }
                else
                {
                    passed = false;
                }
            }
            catch
            {
                passed = false;
            }

            if (passed)
            {
                pboDoB.Image = new Bitmap("tick.png");
            }
            else
            {
                pboDoB.Image = new Bitmap("cross.png");
            }
        }

     

      
    

    
    
    }
}
