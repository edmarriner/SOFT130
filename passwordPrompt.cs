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
    public partial class frmPasswordPrompt : Form
    {
        public frmPasswordPrompt(file this_fileClass)
        {
            InitializeComponent();
            fileClass = this_fileClass;
        }

        file fileClass;
        char char1;
        char char2;
        char char3;


        public void firstPasswordValidate(object sender, EventArgs e)
        {
            if (txt1stChar.Text.Length == 1)
            {
                txt2ndChar.Focus();
            }
        }

        public void secondPasswordValidate(object sender, EventArgs e)
        {
            if (txt2ndChar.Text.Length == 1)
            {
                txt3rdChar.Focus();
            }
        }

        public void thirdPasswordValidate(object sender, EventArgs e)
        {
            if (txt3rdChar.Text.Length == 1)
            {
            }
        }

        private void frmPasswordPrompt_Load(object sender, EventArgs e)
        {
            generateVerification();
            tmrDateTime_Tick(sender, e);
        }

        private void generateVerification()
        {
            int currentCustomerNum = fileClass.getcurrentCustomerNum();
            ArrayList returnedData = fileClass.readFile();

            Customer thisCustomer = (Customer)returnedData[currentCustomerNum];

            txt1stChar.Text = "";
            txt2ndChar.Text = "";
            txt3rdChar.Text = "";

            string password = thisCustomer.getpassword();
            float passwordLen = password.Length;

            int char1s = 1;
            int char1f = Convert.ToInt32(Math.Floor(passwordLen / 3f));

            int char2s = char1f + 1;
            int char2f = char2s + char1f;

            int char3s = char2f + 1;
            int char3f = Convert.ToInt32(passwordLen);

            Random random = new Random();
            int randomNum = random.Next(char1s, char1f + 1);
            lbl1stChar.Text = "#" + randomNum;
            char1 = password[randomNum - 1];

            randomNum = random.Next(char2s, char2f + 1);
            lbl2ndChar.Text = "#" + randomNum;
            char2 = password[randomNum - 1];

            randomNum = random.Next(char3s, char3f + 1);
            lbl3rdChar.Text = "#" + randomNum;
            char3 = password[randomNum - 1];

            txt1stChar.Focus();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            verifyPassword();
        }

        private void verifyPassword()
        {
            if (Convert.ToString(char1) == txt1stChar.Text &&
               Convert.ToString(char2) == txt2ndChar.Text &&
               Convert.ToString(char3) == txt3rdChar.Text)
            {
                frmCustomerView frmCustomerView = new frmCustomerView(fileClass);
                frmCustomerView.Show();
                this.Close();
            }
            else
            {
                generateVerification();
                lblFeedback.Text = "The data entered was incorrect.";
                 MessageBox.Show("WRONG. " 
                   + char1 + "," + char2 + "," + char3);
            }

        }

        private void txt3rdChar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                verifyPassword();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            frmCustomerView frmCustomerView = new frmCustomerView(fileClass);
            frmCustomerView.Show();
            this.Close();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime CurrTime = DateTime.Now;
            lblDate.Text = CurrTime.ToString("D");
            lblTime.Text = CurrTime.ToString("hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
