namespace Gym_Management_System
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subduration = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backtohome2 = new System.Windows.Forms.Button();
            this.paymentTextbox = new RoundedTextBox();
            this.memberIdTextbox = new RoundedTextBox();
            this.nameTextbox = new RoundedTextBox();
            this.roundedPictureBox1 = new RoundedPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPictureBox2 = new RoundedPictureBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = " PAYMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Member ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(60, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Membership Duration:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // subduration
            // 
            this.subduration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subduration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subduration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subduration.FormattingEnabled = true;
            this.subduration.Items.AddRange(new object[] {
            "1 Month",
            "3 Months",
            "5  Months",
            "1 Year"});
            this.subduration.Location = new System.Drawing.Point(61, 618);
            this.subduration.Name = "subduration";
            this.subduration.Size = new System.Drawing.Size(264, 24);
            this.subduration.TabIndex = 38;
            this.subduration.SelectedIndexChanged += new System.EventHandler(this.subduration_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(60, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Enter Name: ";
            // 
            // Continue
            // 
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(65, 801);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(109, 41);
            this.Continue.TabIndex = 41;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(60, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Payment:";
            // 
            // backtohome2
            // 
            this.backtohome2.BackColor = System.Drawing.Color.Transparent;
            this.backtohome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtohome2.BackgroundImage")));
            this.backtohome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtohome2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtohome2.FlatAppearance.BorderSize = 0;
            this.backtohome2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backtohome2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backtohome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtohome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtohome2.ForeColor = System.Drawing.Color.Transparent;
            this.backtohome2.Location = new System.Drawing.Point(12, 23);
            this.backtohome2.Name = "backtohome2";
            this.backtohome2.Size = new System.Drawing.Size(60, 39);
            this.backtohome2.TabIndex = 44;
            this.backtohome2.UseVisualStyleBackColor = false;
            this.backtohome2.Click += new System.EventHandler(this.backtohome2_Click);
            // 
            // paymentTextbox
            // 
            this.paymentTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paymentTextbox.BorderRadius = 20;
            this.paymentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTextbox.Location = new System.Drawing.Point(65, 724);
            this.paymentTextbox.Multiline = true;
            this.paymentTextbox.Name = "paymentTextbox";
            this.paymentTextbox.Size = new System.Drawing.Size(264, 44);
            this.paymentTextbox.TabIndex = 50;
            // 
            // memberIdTextbox
            // 
            this.memberIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memberIdTextbox.BorderRadius = 20;
            this.memberIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberIdTextbox.Location = new System.Drawing.Point(61, 362);
            this.memberIdTextbox.Multiline = true;
            this.memberIdTextbox.Name = "memberIdTextbox";
            this.memberIdTextbox.Size = new System.Drawing.Size(264, 44);
            this.memberIdTextbox.TabIndex = 51;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextbox.BorderRadius = 20;
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextbox.Location = new System.Drawing.Point(62, 489);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(264, 44);
            this.nameTextbox.TabIndex = 52;
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundedPictureBox1.BorderRadius = 80;
            this.roundedPictureBox1.Location = new System.Drawing.Point(36, 161);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(530, 800);
            this.roundedPictureBox1.TabIndex = 54;
            this.roundedPictureBox1.TabStop = false;
            this.roundedPictureBox1.Click += new System.EventHandler(this.roundedPictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(222, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 33);
            this.label9.TabIndex = 55;
            this.label9.Text = "PAYMENT";
            // 
            // roundedPictureBox2
            // 
            this.roundedPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox2.BackgroundImage")));
            this.roundedPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedPictureBox2.BorderRadius = 80;
            this.roundedPictureBox2.Location = new System.Drawing.Point(654, 161);
            this.roundedPictureBox2.Name = "roundedPictureBox2";
            this.roundedPictureBox2.Size = new System.Drawing.Size(1238, 800);
            this.roundedPictureBox2.TabIndex = 56;
            this.roundedPictureBox2.TabStop = false;
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
            this.resetbutton.Location = new System.Drawing.Point(180, 801);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(46, 46);
            this.resetbutton.TabIndex = 57;
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Font = new System.Drawing.Font("Ebrima", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(115, 897);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Don\'t have an account yet? Register here.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 832);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 36);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.roundedPictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.memberIdTextbox);
            this.Controls.Add(this.paymentTextbox);
            this.Controls.Add(this.backtohome2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subduration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox subduration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button backtohome2;
        private RoundedTextBox paymentTextbox;
        private RoundedTextBox memberIdTextbox;
        private RoundedTextBox nameTextbox;
        private RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.Label label9;
        private RoundedPictureBox roundedPictureBox2;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}