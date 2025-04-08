namespace Gym_Management_System
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.gymtime = new System.Windows.Forms.ComboBox();
            this.subduration = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.el1 = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pssword = new System.Windows.Forms.Label();
            this.Offers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.joindate = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Usertxt2 = new RoundedTextBox();
            this.fnametxt = new RoundedTextBox();
            this.lnametxt = new RoundedTextBox();
            this.passwordtxt = new RoundedTextBox();
            this.roundedPictureBox1 = new RoundedPictureBox();
            this.email = new RoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mobilenumtxt = new RoundedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdate
            // 
            this.bdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate.Location = new System.Drawing.Point(632, 576);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(227, 25);
            this.bdate.TabIndex = 9;
            this.bdate.ValueChanged += new System.EventHandler(this.bdate_ValueChanged);
            // 
            // gymtime
            // 
            this.gymtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gymtime.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymtime.ForeColor = System.Drawing.Color.White;
            this.gymtime.FormattingEnabled = true;
            this.gymtime.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.gymtime.Location = new System.Drawing.Point(1115, 405);
            this.gymtime.Name = "gymtime";
            this.gymtime.Size = new System.Drawing.Size(229, 25);
            this.gymtime.TabIndex = 12;
            this.gymtime.SelectedIndexChanged += new System.EventHandler(this.gymtime_SelectedIndexChanged);
            // 
            // subduration
            // 
            this.subduration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subduration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subduration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subduration.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subduration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subduration.FormattingEnabled = true;
            this.subduration.Items.AddRange(new object[] {
            "1 Month",
            "3 Months",
            "5  Months",
            "1 Year"});
            this.subduration.Location = new System.Drawing.Point(1112, 665);
            this.subduration.Name = "subduration";
            this.subduration.Size = new System.Drawing.Size(227, 31);
            this.subduration.TabIndex = 13;
            this.subduration.SelectedIndexChanged += new System.EventHandler(this.subduration_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1109, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Membership Duration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(627, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.genderlbl.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.ForeColor = System.Drawing.Color.White;
            this.genderlbl.Location = new System.Drawing.Point(627, 539);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(90, 25);
            this.genderlbl.TabIndex = 16;
            this.genderlbl.Text = "Birth Date";
            this.genderlbl.Click += new System.EventHandler(this.genderlbl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-160, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1110, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gym Time";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.usernamelbl.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(627, 273);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(101, 25);
            this.usernamelbl.TabIndex = 4;
            this.usernamelbl.Text = "First Name:";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // el1
            // 
            this.el1.AutoSize = true;
            this.el1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.el1.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el1.ForeColor = System.Drawing.Color.White;
            this.el1.Location = new System.Drawing.Point(627, 370);
            this.el1.Name = "el1";
            this.el1.Size = new System.Drawing.Size(95, 25);
            this.el1.TabIndex = 24;
            this.el1.Text = "Last Name";
            this.el1.Click += new System.EventHandler(this.el1_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Orange;
            this.Savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebutton.FlatAppearance.BorderSize = 0;
            this.Savebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Savebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.Black;
            this.Savebutton.Location = new System.Drawing.Point(909, 750);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(153, 57);
            this.Savebutton.TabIndex = 29;
            this.Savebutton.Text = "Register";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.AutoSize = true;
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.resetbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbutton.FlatAppearance.BorderSize = 0;
            this.resetbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbutton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetbutton.Image = ((System.Drawing.Image)(resources.GetObject("resetbutton.Image")));
            this.resetbutton.Location = new System.Drawing.Point(1068, 761);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(46, 46);
            this.resetbutton.TabIndex = 30;
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // genderCmb
            // 
            this.genderCmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCmb.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCmb.ForeColor = System.Drawing.SystemColors.Window;
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCmb.Location = new System.Drawing.Point(632, 498);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(121, 24);
            this.genderCmb.TabIndex = 33;
            this.genderCmb.SelectedIndexChanged += new System.EventHandler(this.genderCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1111, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pssword
            // 
            this.pssword.AutoSize = true;
            this.pssword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pssword.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pssword.ForeColor = System.Drawing.Color.White;
            this.pssword.Location = new System.Drawing.Point(1107, 538);
            this.pssword.Name = "pssword";
            this.pssword.Size = new System.Drawing.Size(88, 25);
            this.pssword.TabIndex = 37;
            this.pssword.Text = "Password";
            this.pssword.Click += new System.EventHandler(this.pssword_Click);
            // 
            // Offers
            // 
            this.Offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Offers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Offers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Offers.FlatAppearance.BorderSize = 0;
            this.Offers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Offers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Offers.Font = new System.Drawing.Font("Ebrima", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offers.ForeColor = System.Drawing.Color.Transparent;
            this.Offers.Location = new System.Drawing.Point(909, 853);
            this.Offers.Name = "Offers";
            this.Offers.Size = new System.Drawing.Size(153, 43);
            this.Offers.TabIndex = 39;
            this.Offers.Text = "View Offers";
            this.Offers.UseVisualStyleBackColor = false;
            this.Offers.Click += new System.EventHandler(this.Offers_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(880, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Orange;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(1210, 807);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 60);
            this.Login.TabIndex = 42;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Orange;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.Black;
            this.Admin.Location = new System.Drawing.Point(632, 807);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(131, 60);
            this.Admin.TabIndex = 43;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // joindate
            // 
            this.joindate.Location = new System.Drawing.Point(653, 408);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(100, 22);
            this.joindate.TabIndex = 45;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1345, 583);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Usertxt2
            // 
            this.Usertxt2.AllowDrop = true;
            this.Usertxt2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Usertxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Usertxt2.BorderRadius = 20;
            this.Usertxt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usertxt2.Location = new System.Drawing.Point(1112, 490);
            this.Usertxt2.Multiline = true;
            this.Usertxt2.Name = "Usertxt2";
            this.Usertxt2.Size = new System.Drawing.Size(227, 44);
            this.Usertxt2.TabIndex = 53;
            // 
            // fnametxt
            // 
            this.fnametxt.AllowDrop = true;
            this.fnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnametxt.BorderRadius = 20;
            this.fnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(632, 301);
            this.fnametxt.Multiline = true;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(227, 43);
            this.fnametxt.TabIndex = 52;
            // 
            // lnametxt
            // 
            this.lnametxt.AllowDrop = true;
            this.lnametxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnametxt.BorderRadius = 20;
            this.lnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnametxt.Location = new System.Drawing.Point(632, 398);
            this.lnametxt.Multiline = true;
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(227, 44);
            this.lnametxt.TabIndex = 51;
            // 
            // passwordtxt
            // 
            this.passwordtxt.AllowDrop = true;
            this.passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtxt.BorderRadius = 20;
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Location = new System.Drawing.Point(1112, 575);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '•';
            this.passwordtxt.Size = new System.Drawing.Size(227, 44);
            this.passwordtxt.TabIndex = 50;
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedPictureBox1.BorderRadius = 80;
            this.roundedPictureBox1.Location = new System.Drawing.Point(394, 31);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(1162, 907);
            this.roundedPictureBox1.TabIndex = 49;
            this.roundedPictureBox1.TabStop = false;
            this.roundedPictureBox1.Click += new System.EventHandler(this.roundedPictureBox1_Click);
            // 
            // email
            // 
            this.email.AllowDrop = true;
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.BorderRadius = 20;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Location = new System.Drawing.Point(632, 666);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(227, 44);
            this.email.TabIndex = 55;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(627, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(679, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "(optional)";
            // 
            // Mobilenumtxt
            // 
            this.Mobilenumtxt.AllowDrop = true;
            this.Mobilenumtxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Mobilenumtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mobilenumtxt.BorderRadius = 20;
            this.Mobilenumtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobilenumtxt.Location = new System.Drawing.Point(1112, 300);
            this.Mobilenumtxt.Multiline = true;
            this.Mobilenumtxt.Name = "Mobilenumtxt";
            this.Mobilenumtxt.Size = new System.Drawing.Size(227, 44);
            this.Mobilenumtxt.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1111, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1249, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "(optional)";
            // 
            // NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mobilenumtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Usertxt2);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Offers);
            this.Controls.Add(this.pssword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.el1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subduration);
            this.Controls.Add(this.gymtime);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.roundedPictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMember";
            this.Text = "NewMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.ComboBox gymtime;
        private System.Windows.Forms.ComboBox subduration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label el1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pssword;
        private System.Windows.Forms.Button Offers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.TextBox joindate;
        private System.Windows.Forms.CheckBox checkBox1;
        private RoundedPictureBox roundedPictureBox1;
        private RoundedTextBox passwordtxt;
        private RoundedTextBox lnametxt;
        private RoundedTextBox fnametxt;
        private RoundedTextBox Usertxt2;
        private RoundedTextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private RoundedTextBox Mobilenumtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}