namespace SOFT130Project
{
    partial class frmCustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAdd));
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDoBDD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.cboDoBMM = new System.Windows.Forms.ComboBox();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCityTown = new System.Windows.Forms.TextBox();
            this.txtDoBYYYY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtNumberName = new System.Windows.Forms.TextBox();
            this.txtAddressArea = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pboPassword = new System.Windows.Forms.PictureBox();
            this.pboDoB = new System.Windows.Forms.PictureBox();
            this.pboSurname = new System.Windows.Forms.PictureBox();
            this.pboFirstName = new System.Windows.Forms.PictureBox();
            this.pboPostcode = new System.Windows.Forms.PictureBox();
            this.pboCityTown = new System.Windows.Forms.PictureBox();
            this.pboStreetName = new System.Windows.Forms.PictureBox();
            this.pboNumberName = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPostcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCityTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboStreetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboNumberName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(167, 126);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(157, 26);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.validateSurname);
            this.txtSurname.Enter += new System.EventHandler(this.validateSurname);
            this.txtSurname.Leave += new System.EventHandler(this.validateSurname);
            // 
            // txtDoBDD
            // 
            this.txtDoBDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoBDD.Location = new System.Drawing.Point(167, 161);
            this.txtDoBDD.MaxLength = 2;
            this.txtDoBDD.Name = "txtDoBDD";
            this.txtDoBDD.Size = new System.Drawing.Size(36, 26);
            this.txtDoBDD.TabIndex = 5;
            this.txtDoBDD.TextChanged += new System.EventHandler(this.validateDoB);
            this.txtDoBDD.Enter += new System.EventHandler(this.validateDoB);
            this.txtDoBDD.Leave += new System.EventHandler(this.validateDoB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Initials:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Surname:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date of Birth:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Number / Name:*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address Area:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "City/Town:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Street Name:*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "County:*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Title:*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Postcode:*";
            // 
            // cboTitle
            // 
            this.cboTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Mrs",
            "Miss"});
            this.cboTitle.Location = new System.Drawing.Point(167, 19);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(83, 28);
            this.cboTitle.TabIndex = 1;
            this.cboTitle.Text = "Mr";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCustomer.Location = new System.Drawing.Point(47, 583);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(132, 33);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // cboDoBMM
            // 
            this.cboDoBMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoBMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoBMM.FormattingEnabled = true;
            this.cboDoBMM.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboDoBMM.Location = new System.Drawing.Point(209, 160);
            this.cboDoBMM.Name = "cboDoBMM";
            this.cboDoBMM.Size = new System.Drawing.Size(53, 28);
            this.cboDoBMM.TabIndex = 6;
            this.cboDoBMM.SelectedIndexChanged += new System.EventHandler(this.validateDoB);
            // 
            // txtInitials
            // 
            this.txtInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitials.Location = new System.Drawing.Point(167, 91);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(56, 26);
            this.txtInitials.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(167, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(157, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.validateFirstName);
            this.txtFirstName.Enter += new System.EventHandler(this.validateFirstName);
            this.txtFirstName.Leave += new System.EventHandler(this.validateFirstName);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(167, 194);
            this.txtPostcode.MaxLength = 7;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(83, 26);
            this.txtPostcode.TabIndex = 13;
            this.txtPostcode.TextChanged += new System.EventHandler(this.validatePostcode);
            this.txtPostcode.Enter += new System.EventHandler(this.validatePostcode);
            this.txtPostcode.Leave += new System.EventHandler(this.validatePostcode);
            // 
            // txtCityTown
            // 
            this.txtCityTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityTown.Location = new System.Drawing.Point(167, 124);
            this.txtCityTown.Name = "txtCityTown";
            this.txtCityTown.Size = new System.Drawing.Size(109, 26);
            this.txtCityTown.TabIndex = 11;
            this.txtCityTown.TextChanged += new System.EventHandler(this.validateCityTown);
            this.txtCityTown.Enter += new System.EventHandler(this.validateCityTown);
            this.txtCityTown.Leave += new System.EventHandler(this.validateCityTown);
            // 
            // txtDoBYYYY
            // 
            this.txtDoBYYYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoBYYYY.Location = new System.Drawing.Point(268, 161);
            this.txtDoBYYYY.MaxLength = 4;
            this.txtDoBYYYY.Name = "txtDoBYYYY";
            this.txtDoBYYYY.Size = new System.Drawing.Size(43, 26);
            this.txtDoBYYYY.TabIndex = 7;
            this.txtDoBYYYY.TextChanged += new System.EventHandler(this.validateDoB);
            this.txtDoBYYYY.Enter += new System.EventHandler(this.validateDoB);
            this.txtDoBYYYY.Leave += new System.EventHandler(this.validateDoB);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pboPostcode);
            this.groupBox1.Controls.Add(this.pboCityTown);
            this.groupBox1.Controls.Add(this.pboStreetName);
            this.groupBox1.Controls.Add(this.pboNumberName);
            this.groupBox1.Controls.Add(this.cboCounty);
            this.groupBox1.Controls.Add(this.txtNumberName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCityTown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPostcode);
            this.groupBox1.Controls.Add(this.txtAddressArea);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtStreetName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(27, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Aberdeenshire",
            "Angus",
            "Antrim",
            "Argyll",
            "Armagh",
            "Avon",
            "Ayrshire",
            "Banffshire",
            "Bedfordshire",
            "Berkshire",
            "Berwickshire",
            "Buckinghamshire",
            "Bute",
            "Caithness",
            "Cambridgeshire",
            "Cheshire",
            "Clackmannanshire",
            "Cleveland",
            "Clwyd",
            "Cornwall",
            "Cumbria",
            "Derbyshire",
            "Devon",
            "Dorset",
            "Down",
            "Dumfriesshire",
            "Dunbartonshire",
            "Durham",
            "Dyfed",
            "East Lothian",
            "East Sussex",
            "Essex",
            "Fermanagh",
            "Fife",
            "Gloucestershire",
            "Gwent",
            "Gwynedd",
            "Hampshire",
            "Herefordshire",
            "Hertfordshire",
            "Inverness-shire",
            "Isle of Wight",
            "Kent",
            "Kincardineshire",
            "Kinross-shire",
            "Kirkcudbrightshire",
            "Lanarkshire",
            "Lancashire",
            "Leicestershire",
            "Lincolnshire",
            "London",
            "Londonderry",
            "Merseyside",
            "Mid Glamorgan",
            "Middlesex",
            "Midlothian",
            "Moray",
            "Nairnshire",
            "Norfolk",
            "North Humberside",
            "North Yorkshire",
            "Northamptonshire",
            "Northumberland",
            "Nottinghamshire",
            "Orkney",
            "Oxfordshire",
            "Peeblesshire",
            "Perthshire",
            "Powys",
            "Renfrewshire",
            "Ross-shire",
            "Roxburghshire",
            "Rutland",
            "Selkirkshire",
            "Shetland",
            "Shropshire",
            "Somerset",
            "South Glamorgan",
            "South Humberside",
            "South Yorkshire",
            "Staffordshire",
            "Stirlingshire",
            "Suffolk",
            "Surrey",
            "Sutherland",
            "Tyne and Wear",
            "Tyrone",
            "Warwickshire",
            "West Glamorgan",
            "West Lothian",
            "West Midlands",
            "West Sussex",
            "West Yorkshire",
            "Wigtownshire",
            "Wiltshire",
            "Worcestershire"});
            this.cboCounty.Location = new System.Drawing.Point(167, 158);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(163, 28);
            this.cboCounty.Sorted = true;
            this.cboCounty.TabIndex = 12;
            // 
            // txtNumberName
            // 
            this.txtNumberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberName.Location = new System.Drawing.Point(167, 22);
            this.txtNumberName.Name = "txtNumberName";
            this.txtNumberName.Size = new System.Drawing.Size(65, 26);
            this.txtNumberName.TabIndex = 8;
            this.txtNumberName.TextChanged += new System.EventHandler(this.validateNumberName);
            this.txtNumberName.Enter += new System.EventHandler(this.validateNumberName);
            this.txtNumberName.Leave += new System.EventHandler(this.validateNumberName);
            // 
            // txtAddressArea
            // 
            this.txtAddressArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressArea.Location = new System.Drawing.Point(167, 90);
            this.txtAddressArea.Name = "txtAddressArea";
            this.txtAddressArea.Size = new System.Drawing.Size(157, 26);
            this.txtAddressArea.TabIndex = 10;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetName.Location = new System.Drawing.Point(167, 56);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(230, 26);
            this.txtStreetName.TabIndex = 9;
            this.txtStreetName.TextChanged += new System.EventHandler(this.validateStreetName);
            this.txtStreetName.Enter += new System.EventHandler(this.validateStreetName);
            this.txtStreetName.Leave += new System.EventHandler(this.validateStreetName);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pboPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.pboDoB);
            this.groupBox2.Controls.Add(this.pboSurname);
            this.groupBox2.Controls.Add(this.pboFirstName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtDoBYYYY);
            this.groupBox2.Controls.Add(this.txtDoBDD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInitials);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboDoBMM);
            this.groupBox2.Controls.Add(this.cboTitle);
            this.groupBox2.Location = new System.Drawing.Point(27, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 231);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(167, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 26);
            this.txtPassword.TabIndex = 59;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.validatePassword);
            this.txtPassword.Enter += new System.EventHandler(this.validatePassword);
            this.txtPassword.Leave += new System.EventHandler(this.validatePassword);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "(DDMMMYYYY)";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(194, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 33);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.SkyBlue;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(279, 16);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(172, 20);
            this.lbldate.TabIndex = 53;
            this.lbldate.Text = "Add a new customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.BackgroundImage = global::SOFT130Project.Properties.Resources.hmbc;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 45);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(847, 69);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pboPassword
            // 
            this.pboPassword.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboPassword.Location = new System.Drawing.Point(312, 199);
            this.pboPassword.Name = "pboPassword";
            this.pboPassword.Size = new System.Drawing.Size(16, 16);
            this.pboPassword.TabIndex = 61;
            this.pboPassword.TabStop = false;
            // 
            // pboDoB
            // 
            this.pboDoB.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboDoB.Location = new System.Drawing.Point(317, 167);
            this.pboDoB.Name = "pboDoB";
            this.pboDoB.Size = new System.Drawing.Size(16, 16);
            this.pboDoB.TabIndex = 52;
            this.pboDoB.TabStop = false;
            // 
            // pboSurname
            // 
            this.pboSurname.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboSurname.Location = new System.Drawing.Point(330, 129);
            this.pboSurname.Name = "pboSurname";
            this.pboSurname.Size = new System.Drawing.Size(16, 16);
            this.pboSurname.TabIndex = 51;
            this.pboSurname.TabStop = false;
            // 
            // pboFirstName
            // 
            this.pboFirstName.Image = global::SOFT130Project.Properties.Resources.cross;
            this.pboFirstName.Location = new System.Drawing.Point(330, 60);
            this.pboFirstName.Name = "pboFirstName";
            this.pboFirstName.Size = new System.Drawing.Size(16, 16);
            this.pboFirstName.TabIndex = 49;
            this.pboFirstName.TabStop = false;
            // 
            // pboPostcode
            // 
            this.pboPostcode.Image = ((System.Drawing.Image)(resources.GetObject("pboPostcode.Image")));
            this.pboPostcode.Location = new System.Drawing.Point(256, 201);
            this.pboPostcode.Name = "pboPostcode";
            this.pboPostcode.Size = new System.Drawing.Size(16, 16);
            this.pboPostcode.TabIndex = 57;
            this.pboPostcode.TabStop = false;
            // 
            // pboCityTown
            // 
            this.pboCityTown.Image = ((System.Drawing.Image)(resources.GetObject("pboCityTown.Image")));
            this.pboCityTown.Location = new System.Drawing.Point(282, 131);
            this.pboCityTown.Name = "pboCityTown";
            this.pboCityTown.Size = new System.Drawing.Size(16, 16);
            this.pboCityTown.TabIndex = 56;
            this.pboCityTown.TabStop = false;
            // 
            // pboStreetName
            // 
            this.pboStreetName.Image = ((System.Drawing.Image)(resources.GetObject("pboStreetName.Image")));
            this.pboStreetName.Location = new System.Drawing.Point(403, 63);
            this.pboStreetName.Name = "pboStreetName";
            this.pboStreetName.Size = new System.Drawing.Size(16, 16);
            this.pboStreetName.TabIndex = 54;
            this.pboStreetName.TabStop = false;
            // 
            // pboNumberName
            // 
            this.pboNumberName.Image = ((System.Drawing.Image)(resources.GetObject("pboNumberName.Image")));
            this.pboNumberName.Location = new System.Drawing.Point(238, 29);
            this.pboNumberName.Name = "pboNumberName";
            this.pboNumberName.Size = new System.Drawing.Size(16, 16);
            this.pboNumberName.TabIndex = 53;
            this.pboNumberName.TabStop = false;
            // 
            // frmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(493, 628);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new Customer  - HMBC Inc.";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frmCustomerAdd_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPostcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCityTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboStreetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboNumberName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDoBDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ComboBox cboDoBMM;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCityTown;
        private System.Windows.Forms.TextBox txtDoBYYYY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumberName;
        private System.Windows.Forms.TextBox txtAddressArea;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.PictureBox pboFirstName;
        private System.Windows.Forms.PictureBox pboPostcode;
        private System.Windows.Forms.PictureBox pboCityTown;
        private System.Windows.Forms.PictureBox pboStreetName;
        private System.Windows.Forms.PictureBox pboNumberName;
        private System.Windows.Forms.PictureBox pboDoB;
        private System.Windows.Forms.PictureBox pboSurname;
        private System.Windows.Forms.PictureBox pboPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label13;
    }
}