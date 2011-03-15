namespace SOFT130Project
{
    partial class frmPasswordPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.txtFirstPasswordCharacter = new System.Windows.Forms.TextBox();
            this.lblFirstPasswordCharacter = new System.Windows.Forms.Label();
            this.txtThirdPasswordCharacter = new System.Windows.Forms.TextBox();
            this.txtSecondPasswordCharacter = new System.Windows.Forms.TextBox();
            this.lblSecondPasswordCharacter = new System.Windows.Forms.Label();
            this.lblThirdPasswordCharacter = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(130, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Password";
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(338, 60);
            this.picHeader.TabIndex = 48;
            this.picHeader.TabStop = false;
            // 
            // txtFirstPasswordCharacter
            // 
            this.txtFirstPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPasswordCharacter.Location = new System.Drawing.Point(54, 120);
            this.txtFirstPasswordCharacter.Name = "txtFirstPasswordCharacter";
            this.txtFirstPasswordCharacter.Size = new System.Drawing.Size(36, 26);
            this.txtFirstPasswordCharacter.TabIndex = 54;
            this.txtFirstPasswordCharacter.TextChanged += new System.EventHandler(this.firstPasswordValidate);
            // 
            // lblFirstPasswordCharacter
            // 
            this.lblFirstPasswordCharacter.AutoSize = true;
            this.lblFirstPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPasswordCharacter.Location = new System.Drawing.Point(12, 123);
            this.lblFirstPasswordCharacter.Name = "lblFirstPasswordCharacter";
            this.lblFirstPasswordCharacter.Size = new System.Drawing.Size(36, 20);
            this.lblFirstPasswordCharacter.TabIndex = 51;
            this.lblFirstPasswordCharacter.Text = "3rd:";
            // 
            // txtThirdPasswordCharacter
            // 
            this.txtThirdPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdPasswordCharacter.Location = new System.Drawing.Point(287, 120);
            this.txtThirdPasswordCharacter.Name = "txtThirdPasswordCharacter";
            this.txtThirdPasswordCharacter.Size = new System.Drawing.Size(36, 26);
            this.txtThirdPasswordCharacter.TabIndex = 55;
            this.txtThirdPasswordCharacter.TextChanged += new System.EventHandler(this.thirdPasswordValidate);
            // 
            // txtSecondPasswordCharacter
            // 
            this.txtSecondPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPasswordCharacter.Location = new System.Drawing.Point(172, 120);
            this.txtSecondPasswordCharacter.Name = "txtSecondPasswordCharacter";
            this.txtSecondPasswordCharacter.Size = new System.Drawing.Size(36, 26);
            this.txtSecondPasswordCharacter.TabIndex = 56;
            this.txtSecondPasswordCharacter.TextChanged += new System.EventHandler(this.secondPasswordValidate);
            // 
            // lblSecondPasswordCharacter
            // 
            this.lblSecondPasswordCharacter.AutoSize = true;
            this.lblSecondPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPasswordCharacter.Location = new System.Drawing.Point(130, 123);
            this.lblSecondPasswordCharacter.Name = "lblSecondPasswordCharacter";
            this.lblSecondPasswordCharacter.Size = new System.Drawing.Size(36, 20);
            this.lblSecondPasswordCharacter.TabIndex = 57;
            this.lblSecondPasswordCharacter.Text = "5th:";
            // 
            // lblThirdPasswordCharacter
            // 
            this.lblThirdPasswordCharacter.AutoSize = true;
            this.lblThirdPasswordCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPasswordCharacter.Location = new System.Drawing.Point(245, 123);
            this.lblThirdPasswordCharacter.Name = "lblThirdPasswordCharacter";
            this.lblThirdPasswordCharacter.Size = new System.Drawing.Size(36, 20);
            this.lblThirdPasswordCharacter.TabIndex = 58;
            this.lblThirdPasswordCharacter.Text = "8th:";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerify.Location = new System.Drawing.Point(103, 173);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(132, 33);
            this.btnVerify.TabIndex = 59;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(283, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(284, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 61;
            this.lblTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.BackgroundImage = global::SOFT130Project.Properties.Resources.hmbc;
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 45);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // frmPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblThirdPasswordCharacter);
            this.Controls.Add(this.lblSecondPasswordCharacter);
            this.Controls.Add(this.txtSecondPasswordCharacter);
            this.Controls.Add(this.txtThirdPasswordCharacter);
            this.Controls.Add(this.txtFirstPasswordCharacter);
            this.Controls.Add(this.lblFirstPasswordCharacter);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picHeader);
            this.Name = "frmPasswordPrompt";
            this.Text = "passwordPrompt";
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.TextBox txtFirstPasswordCharacter;
        private System.Windows.Forms.Label lblFirstPasswordCharacter;
        private System.Windows.Forms.TextBox txtThirdPasswordCharacter;
        private System.Windows.Forms.TextBox txtSecondPasswordCharacter;
        private System.Windows.Forms.Label lblSecondPasswordCharacter;
        private System.Windows.Forms.Label lblThirdPasswordCharacter;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}