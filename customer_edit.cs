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
    public partial class frmCustomerEdit : Form
    {
        public frmCustomerEdit(file this_fileClass)
        {
            InitializeComponent();
            fileClass = this_fileClass;
        }

        bool showMainMenu = true;
        file fileClass;
        private void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            int currentCustomerNum = fileClass.getcurrentCustomerNum();
           
            ArrayList returnedData = fileClass.readFile();

            Customer thisCustomer = (Customer)returnedData[currentCustomerNum];

            txtFirstName.Text = thisCustomer.getfirstName();
            txtSurname.Text = thisCustomer.getsurname();
            txtDob.Text = thisCustomer.getdob();
            txtInitials.Text = thisCustomer.getinitials();
            txtTitle.Text = thisCustomer.gettitle();
            txtPassword.Text = thisCustomer.getpassword();
            txtNumberName.Text = thisCustomer.gethouseNameNumber();
            txtStreetName.Text = thisCustomer.getstreetName();
            txtAddressArea.Text = thisCustomer.getaddressArea();
            txtCityTown.Text = thisCustomer.getcityTown();
            txtCounty.Text = thisCustomer.getcounty();
            txtPostcode.Text = thisCustomer.getpostcode();
        }
    }
}
