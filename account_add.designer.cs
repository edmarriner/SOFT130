namespace SOFT130Project
{
    partial class frmAccountAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtOverdraftLimit = new System.Windows.Forms.TextBox();
            this.txtSortCode1 = new System.Windows.Forms.TextBox();
            this.txtSortCode2 = new System.Windows.Forms.TextBox();
            this.txtSortCode3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pboAccountName = new System.Windows.Forms.PictureBox();
            this.pboSortCode = new System.Windows.Forms.PictureBox();
            this.pboOverdraftLimit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAccountName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSortCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOverdraftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Sort Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Overdraft Limit:";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAccount.Location = new System.Drawing.Point(8, 246);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(132, 33);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(146, 125);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(169, 26);
            this.txtAccountName.TabIndex = 1;
            this.txtAccountName.TextChanged += new System.EventHandler(this.validateAccountName);
            this.txtAccountName.Enter += new System.EventHandler(this.validateAccountName);
            this.txtAccountName.Leave += new System.EventHandler(this.validateAccountName);
            // 
            // txtOverdraftLimit
            // 
            this.txtOverdraftLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraftLimit.Location = new System.Drawing.Point(162, 203);
            this.txtOverdraftLimit.Name = "txtOverdraftLimit";
            this.txtOverdraftLimit.Size = new System.Drawing.Size(116, 26);
            this.txtOverdraftLimit.TabIndex = 5;
            this.txtOverdraftLimit.TextChanged += new System.EventHandler(this.validateOverdraftLimit);
            this.txtOverdraftLimit.Enter += new System.EventHandler(this.validateOverdraftLimit);
            // 
            // txtSortCode1
            // 
            this.txtSortCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode1.Location = new System.Drawing.Point(146, 163);
            this.txtSortCode1.Name = "txtSortCode1";
            this.txtSortCode1.Size = new System.Drawing.Size(37, 26);
            this.txtSortCode1.TabIndex = 2;
            this.txtSortCode1.TextChanged += new System.EventHandler(this.validateSortCode);
            this.txtSortCode1.Enter += new System.EventHandler(this.validateSortCode);
            this.txtSortCode1.Leave += new System.EventHandler(this.validateSortCode);
            // 
            // txtSortCode2
            // 
            this.txtSortCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode2.Location = new System.Drawing.Point(193, 163);
            this.txtSortCode2.Name = "txtSortCode2";
            this.txtSortCode2.Size = new System.Drawing.Size(37, 26);
            this.txtSortCode2.TabIndex = 3;
            this.txtSortCode2.TextChanged += new System.EventHandler(this.validateSortCode);
            this.txtSortCode2.Enter += new System.EventHandler(this.validateSortCode);
            this.txtSortCode2.Leave += new System.EventHandler(this.validateSortCode);
            // 
            // txtSortCode3
            // 
            this.txtSortCode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode3.Location = new System.Drawing.Point(241, 162);
            this.txtSortCode3.Name = "txtSortCode3";
            this.txtSortCode3.Size = new System.Drawing.Size(37, 26);
            this.txtSortCode3.TabIndex = 4;
            this.txtSortCode3.TextChanged += new System.EventHandler(this.validateSortCode);
            this.txtSortCode3.Enter += new System.EventHandler(this.validateSortCode);
            this.txtSortCode3.Leave += new System.EventHandler(this.validateSortCode);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "£";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 69);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(149, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(357, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 100;
            // 
            // pboAccountName
            // 
            this.pboAccountName.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboAccountName.Location = new System.Drawing.Point(321, 129);
            this.pboAccountName.Name = "pboAccountName";
            this.pboAccountName.Size = new System.Drawing.Size(16, 16);
            this.pboAccountName.TabIndex = 101;
            this.pboAccountName.TabStop = false;
            // 
            // pboSortCode
            // 
            this.pboSortCode.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboSortCode.Location = new System.Drawing.Point(284, 167);
            this.pboSortCode.Name = "pboSortCode";
            this.pboSortCode.Size = new System.Drawing.Size(16, 16);
            this.pboSortCode.TabIndex = 102;
            this.pboSortCode.TabStop = false;
            // 
            // pboOverdraftLimit
            // 
            this.pboOverdraftLimit.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboOverdraftLimit.Location = new System.Drawing.Point(284, 208);
            this.pboOverdraftLimit.Name = "pboOverdraftLimit";
            this.pboOverdraftLimit.Size = new System.Drawing.Size(16, 16);
            this.pboOverdraftLimit.TabIndex = 103;
            this.pboOverdraftLimit.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.BackgroundImage = global::SOFT130Project.Properties.Resources.hmbc;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 45);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(118, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 121;
            this.lblDescription.Text = "Add Account";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(296, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 122;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(296, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 123;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // frmAccountAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 288);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboOverdraftLimit);
            this.Controls.Add(this.pboSortCode);
            this.Controls.Add(this.pboAccountName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSortCode3);
            this.Controls.Add(this.txtSortCode2);
            this.Controls.Add(this.txtSortCode1);
            this.Controls.Add(this.txtOverdraftLimit);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Account - HMBC Inc.";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAccountName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSortCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboOverdraftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtOverdraftLimit;
        private System.Windows.Forms.TextBox txtSortCode1;
        private System.Windows.Forms.TextBox txtSortCode2;
        private System.Windows.Forms.TextBox txtSortCode3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pboAccountName;
        private System.Windows.Forms.PictureBox pboSortCode;
        private System.Windows.Forms.PictureBox pboOverdraftLimit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}