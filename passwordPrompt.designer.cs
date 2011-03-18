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
            this.components = new System.ComponentModel.Container();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.txt1stChar = new System.Windows.Forms.TextBox();
            this.lbl1stChar = new System.Windows.Forms.Label();
            this.txt3rdChar = new System.Windows.Forms.TextBox();
            this.txt2ndChar = new System.Windows.Forms.TextBox();
            this.lbl2ndChar = new System.Windows.Forms.Label();
            this.lbl3rdChar = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(126, 75);
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
            // txt1stChar
            // 
            this.txt1stChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1stChar.Location = new System.Drawing.Point(54, 136);
            this.txt1stChar.Name = "txt1stChar";
            this.txt1stChar.Size = new System.Drawing.Size(36, 26);
            this.txt1stChar.TabIndex = 1;
            this.txt1stChar.UseSystemPasswordChar = true;
            this.txt1stChar.TextChanged += new System.EventHandler(this.firstPasswordValidate);
            // 
            // lbl1stChar
            // 
            this.lbl1stChar.AutoSize = true;
            this.lbl1stChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stChar.Location = new System.Drawing.Point(12, 139);
            this.lbl1stChar.Name = "lbl1stChar";
            this.lbl1stChar.Size = new System.Drawing.Size(36, 20);
            this.lbl1stChar.TabIndex = 10;
            this.lbl1stChar.Text = "3rd:";
            // 
            // txt3rdChar
            // 
            this.txt3rdChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3rdChar.Location = new System.Drawing.Point(287, 136);
            this.txt3rdChar.Name = "txt3rdChar";
            this.txt3rdChar.Size = new System.Drawing.Size(36, 26);
            this.txt3rdChar.TabIndex = 3;
            this.txt3rdChar.UseSystemPasswordChar = true;
            this.txt3rdChar.TextChanged += new System.EventHandler(this.thirdPasswordValidate);
            this.txt3rdChar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt3rdChar_KeyUp);
            // 
            // txt2ndChar
            // 
            this.txt2ndChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2ndChar.Location = new System.Drawing.Point(172, 136);
            this.txt2ndChar.Name = "txt2ndChar";
            this.txt2ndChar.Size = new System.Drawing.Size(36, 26);
            this.txt2ndChar.TabIndex = 2;
            this.txt2ndChar.UseSystemPasswordChar = true;
            this.txt2ndChar.TextChanged += new System.EventHandler(this.secondPasswordValidate);
            // 
            // lbl2ndChar
            // 
            this.lbl2ndChar.AutoSize = true;
            this.lbl2ndChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndChar.Location = new System.Drawing.Point(130, 139);
            this.lbl2ndChar.Name = "lbl2ndChar";
            this.lbl2ndChar.Size = new System.Drawing.Size(36, 20);
            this.lbl2ndChar.TabIndex = 10;
            this.lbl2ndChar.Text = "5th:";
            // 
            // lbl3rdChar
            // 
            this.lbl3rdChar.AutoSize = true;
            this.lbl3rdChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3rdChar.Location = new System.Drawing.Point(245, 139);
            this.lbl3rdChar.Name = "lbl3rdChar";
            this.lbl3rdChar.Size = new System.Drawing.Size(36, 20);
            this.lbl3rdChar.TabIndex = 10;
            this.lbl3rdChar.Text = "8th:";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerify.Location = new System.Drawing.Point(103, 173);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(132, 33);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(255, 8);
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
            this.lblTime.Location = new System.Drawing.Point(256, 33);
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
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(13, 109);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 124;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(278, 182);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(49, 24);
            this.btnSkip.TabIndex = 125;
            this.btnSkip.Text = "skip...";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // frmPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 218);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lbl3rdChar);
            this.Controls.Add(this.lbl2ndChar);
            this.Controls.Add(this.txt2ndChar);
            this.Controls.Add(this.txt3rdChar);
            this.Controls.Add(this.txt1stChar);
            this.Controls.Add(this.lbl1stChar);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasswordPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passwordPrompt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPasswordPrompt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.TextBox txt1stChar;
        private System.Windows.Forms.Label lbl1stChar;
        private System.Windows.Forms.TextBox txt3rdChar;
        private System.Windows.Forms.TextBox txt2ndChar;
        private System.Windows.Forms.Label lbl2ndChar;
        private System.Windows.Forms.Label lbl3rdChar;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Timer tmrDateTime;
    }
}