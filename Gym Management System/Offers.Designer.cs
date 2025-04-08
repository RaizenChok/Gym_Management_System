namespace Gym_Management_System
{
    partial class Offers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offers));
            this.Savebutton = new System.Windows.Forms.Button();
            this.backtohome2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Orange;
            this.Savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebutton.FlatAppearance.BorderSize = 0;
            this.Savebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Savebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(287, 895);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(215, 70);
            this.Savebutton.TabIndex = 30;
            this.Savebutton.Text = "Get Started";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // backtohome2
            // 
            this.backtohome2.BackColor = System.Drawing.Color.Transparent;
            this.backtohome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtohome2.BackgroundImage")));
            this.backtohome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtohome2.FlatAppearance.BorderSize = 0;
            this.backtohome2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backtohome2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backtohome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtohome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtohome2.ForeColor = System.Drawing.Color.Transparent;
            this.backtohome2.Location = new System.Drawing.Point(21, 12);
            this.backtohome2.Name = "backtohome2";
            this.backtohome2.Size = new System.Drawing.Size(60, 39);
            this.backtohome2.TabIndex = 34;
            this.backtohome2.UseVisualStyleBackColor = false;
            this.backtohome2.Click += new System.EventHandler(this.backtohome2_Click);
            // 
            // Offers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.backtohome2);
            this.Controls.Add(this.Savebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Offers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button backtohome2;
    }
}