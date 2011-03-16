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
    public partial class frmPasswordPrompt : Form
    {
        public frmPasswordPrompt()
        {
            InitializeComponent();
        }


        public void firstPasswordValidate(object sender, EventArgs e)
        {
            if (txtFirstPasswordCharacter.Text.Length == 1)
            {
                txtSecondPasswordCharacter.Focus();
            }
        }

        public void secondPasswordValidate(object sender, EventArgs e)
        {
            if (txtSecondPasswordCharacter.Text.Length == 1)
            {
                txtThirdPasswordCharacter.Focus();
            }
        }

        public void thirdPasswordValidate(object sender, EventArgs e)
        {
            if (txtThirdPasswordCharacter.Text.Length == 1)
            {
            }
        }
    }
}
