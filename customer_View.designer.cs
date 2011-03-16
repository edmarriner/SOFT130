namespace SOFT130Project
{
    partial class frmCustomerView
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSelectAccount = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCustomerPostcode = new System.Windows.Forms.Label();
            this.lblCustomerCounty = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCustomerTownOrCity = new System.Windows.Forms.Label();
            this.lblTownOrCity = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerStreet = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCustomerHouseNameOrNum = new System.Windows.Forms.Label();
            this.lblHouseNameOrNum = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerDOB = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpAccounts = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.grpAddress.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(338, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 73;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(337, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 72;
            this.lblDate.Text = "Date";
            // 
            // btnSelectAccount
            // 
            this.btnSelectAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectAccount.Location = new System.Drawing.Point(6, 115);
            this.btnSelectAccount.Name = "btnSelectAccount";
            this.btnSelectAccount.Size = new System.Drawing.Size(86, 33);
            this.btnSelectAccount.TabIndex = 71;
            this.btnSelectAccount.Text = "View";
            this.btnSelectAccount.UseVisualStyleBackColor = false;
            this.btnSelectAccount.Click += new System.EventHandler(this.btnSelectAccount_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(159, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 64;
            this.lblDescription.Text = "Customer";
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(393, 60);
            this.picHeader.TabIndex = 62;
            this.picHeader.TabStop = false;
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.tableLayoutPanel1);
            this.grpAddress.Location = new System.Drawing.Point(16, 204);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(365, 159);
            this.grpAddress.TabIndex = 79;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel1.Controls.Add(this.lblPostcode, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerPostcode, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerCounty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCounty, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerTownOrCity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTownOrCity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerStreet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStreet, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerHouseNameOrNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHouseNameOrNum, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(82, 114);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(80, 20);
            this.lblPostcode.TabIndex = 89;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblCustomerPostcode
            // 
            this.lblCustomerPostcode.AutoSize = true;
            this.lblCustomerPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPostcode.Location = new System.Drawing.Point(168, 114);
            this.lblCustomerPostcode.Name = "lblCustomerPostcode";
            this.lblCustomerPostcode.Size = new System.Drawing.Size(81, 20);
            this.lblCustomerPostcode.TabIndex = 88;
            this.lblCustomerPostcode.Text = "EX12 7PL";
            // 
            // lblCustomerCounty
            // 
            this.lblCustomerCounty.AutoSize = true;
            this.lblCustomerCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCounty.Location = new System.Drawing.Point(168, 91);
            this.lblCustomerCounty.Name = "lblCustomerCounty";
            this.lblCustomerCounty.Size = new System.Drawing.Size(55, 20);
            this.lblCustomerCounty.TabIndex = 87;
            this.lblCustomerCounty.Text = "Devon";
            // 
            // lblCounty
            // 
            this.lblCounty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(99, 91);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(63, 20);
            this.lblCounty.TabIndex = 86;
            this.lblCounty.Text = "County:";
            // 
            // lblCustomerTownOrCity
            // 
            this.lblCustomerTownOrCity.AutoSize = true;
            this.lblCustomerTownOrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTownOrCity.Location = new System.Drawing.Point(168, 67);
            this.lblCustomerTownOrCity.Name = "lblCustomerTownOrCity";
            this.lblCustomerTownOrCity.Size = new System.Drawing.Size(55, 20);
            this.lblCustomerTownOrCity.TabIndex = 85;
            this.lblCustomerTownOrCity.Text = "Exeter";
            // 
            // lblTownOrCity
            // 
            this.lblTownOrCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTownOrCity.AutoSize = true;
            this.lblTownOrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownOrCity.Location = new System.Drawing.Point(22, 67);
            this.lblTownOrCity.Name = "lblTownOrCity";
            this.lblTownOrCity.Size = new System.Drawing.Size(140, 20);
            this.lblTownOrCity.TabIndex = 84;
            this.lblTownOrCity.Text = "Town or city name:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(168, 44);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(68, 20);
            this.lblCustomerAddress.TabIndex = 83;
            this.lblCustomerAddress.Text = "Linwood";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(54, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 20);
            this.lblAddress.TabIndex = 82;
            this.lblAddress.Text = "Address area:";
            // 
            // lblCustomerStreet
            // 
            this.lblCustomerStreet.AutoSize = true;
            this.lblCustomerStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStreet.Location = new System.Drawing.Point(168, 22);
            this.lblCustomerStreet.Name = "lblCustomerStreet";
            this.lblCustomerStreet.Size = new System.Drawing.Size(92, 20);
            this.lblCustomerStreet.TabIndex = 81;
            this.lblCustomerStreet.Text = "Walk Street";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(105, 22);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 20);
            this.lblStreet.TabIndex = 80;
            this.lblStreet.Text = "Street:";
            // 
            // lblCustomerHouseNameOrNum
            // 
            this.lblCustomerHouseNameOrNum.AutoSize = true;
            this.lblCustomerHouseNameOrNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHouseNameOrNum.Location = new System.Drawing.Point(168, 0);
            this.lblCustomerHouseNameOrNum.Name = "lblCustomerHouseNameOrNum";
            this.lblCustomerHouseNameOrNum.Size = new System.Drawing.Size(18, 20);
            this.lblCustomerHouseNameOrNum.TabIndex = 79;
            this.lblCustomerHouseNameOrNum.Text = "4";
            // 
            // lblHouseNameOrNum
            // 
            this.lblHouseNameOrNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHouseNameOrNum.AutoSize = true;
            this.lblHouseNameOrNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNameOrNum.Location = new System.Drawing.Point(10, 0);
            this.lblHouseNameOrNum.Name = "lblHouseNameOrNum";
            this.lblHouseNameOrNum.Size = new System.Drawing.Size(152, 20);
            this.lblHouseNameOrNum.TabIndex = 78;
            this.lblHouseNameOrNum.Text = "House name or no. :";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.tableLayoutPanel2);
            this.grpCustomer.Location = new System.Drawing.Point(12, 118);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(369, 80);
            this.grpCustomer.TabIndex = 80;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.30682F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69318F));
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerDOB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDOB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 47);
            this.tableLayoutPanel2.TabIndex = 78;
            // 
            // lblCustomerDOB
            // 
            this.lblCustomerDOB.AutoSize = true;
            this.lblCustomerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDOB.Location = new System.Drawing.Point(166, 23);
            this.lblCustomerDOB.Name = "lblCustomerDOB";
            this.lblCustomerDOB.Size = new System.Drawing.Size(89, 20);
            this.lblCustomerDOB.TabIndex = 75;
            this.lblCustomerDOB.Text = "15/07/1991";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(112, 23);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(48, 20);
            this.lblDOB.TabIndex = 76;
            this.lblDOB.Text = "DOB:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(166, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(74, 20);
            this.lblCustomerName.TabIndex = 74;
            this.lblCustomerName.Text = "Jake Hall";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(105, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 77;
            this.lblName.Text = "Name:";
            // 
            // grpAccounts
            // 
            this.grpAccounts.Controls.Add(this.dgvAccounts);
            this.grpAccounts.Controls.Add(this.btnDelete);
            this.grpAccounts.Controls.Add(this.btnSelectAccount);
            this.grpAccounts.Controls.Add(this.bntEdit);
            this.grpAccounts.Location = new System.Drawing.Point(16, 369);
            this.grpAccounts.Name = "grpAccounts";
            this.grpAccounts.Size = new System.Drawing.Size(365, 154);
            this.grpAccounts.TabIndex = 80;
            this.grpAccounts.TabStop = false;
            this.grpAccounts.Text = "Accounts";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(272, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // bntEdit
            // 
            this.bntEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bntEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntEdit.Location = new System.Drawing.Point(139, 115);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(86, 33);
            this.bntEdit.TabIndex = 81;
            this.bntEdit.Text = "Edit";
            this.bntEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.BackgroundImage = global::SOFT130Project.Properties.Resources.hmbc;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 45);
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.name,
            this.balance});
            this.dgvAccounts.Location = new System.Drawing.Point(6, 19);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(352, 90);
            this.dgvAccounts.TabIndex = 83;
            this.dgvAccounts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentDoubleClick);
            // 
            // num
            // 
            this.num.FillWeight = 50F;
            this.num.HeaderText = "#";
            this.num.Name = "num";
            // 
            // name
            // 
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.FillWeight = 200F;
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // frmCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAccounts);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerView";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerView_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.grpAddress.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSelectAccount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpAccounts;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCustomerCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCustomerTownOrCity;
        private System.Windows.Forms.Label lblTownOrCity;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCustomerHouseNameOrNum;
        private System.Windows.Forms.Label lblHouseNameOrNum;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCustomerPostcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCustomerDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}