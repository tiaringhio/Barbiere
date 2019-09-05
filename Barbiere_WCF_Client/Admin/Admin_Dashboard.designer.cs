namespace Barbiere_WCF_Client.Admin {
    partial class Admin_Dashboard {
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
            this.SideMenu = new System.Windows.Forms.MenuStrip();
            this.MenuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MyBookingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.UsernameDisplayer = new System.Windows.Forms.Label();
            this.DashTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.AutoSize = false;
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SideMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBook,
            this.MyBookingsMenu,
            this.MenuProfile});
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Padding = new System.Windows.Forms.Padding(8, 200, 0, 2);
            this.SideMenu.Size = new System.Drawing.Size(316, 785);
            this.SideMenu.TabIndex = 13;
            this.SideMenu.Text = "menuStrip1";
            // 
            // MenuBook
            // 
            this.MenuBook.AutoSize = false;
            this.MenuBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MenuBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBook.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuBook.Name = "MenuBook";
            this.MenuBook.Size = new System.Drawing.Size(307, 75);
            this.MenuBook.Text = "Book";
            // 
            // MyBookingsMenu
            // 
            this.MyBookingsMenu.AutoSize = false;
            this.MyBookingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MyBookingsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyBookingsMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.MyBookingsMenu.Name = "MyBookingsMenu";
            this.MyBookingsMenu.Size = new System.Drawing.Size(307, 75);
            this.MyBookingsMenu.Text = "My Bookings";
            // 
            // MenuProfile
            // 
            this.MenuProfile.AutoSize = false;
            this.MenuProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MenuProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuProfile.Name = "MenuProfile";
            this.MenuProfile.Size = new System.Drawing.Size(307, 75);
            this.MenuProfile.Text = "Profile";
            // 
            // LogOutLink
            // 
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LogOutLink.LinkColor = System.Drawing.SystemColors.Control;
            this.LogOutLink.Location = new System.Drawing.Point(123, 644);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(55, 16);
            this.LogOutLink.TabIndex = 16;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log-Out";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // UsernameDisplayer
            // 
            this.UsernameDisplayer.AutoSize = true;
            this.UsernameDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UsernameDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameDisplayer.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameDisplayer.Location = new System.Drawing.Point(123, 688);
            this.UsernameDisplayer.Name = "UsernameDisplayer";
            this.UsernameDisplayer.Size = new System.Drawing.Size(47, 24);
            this.UsernameDisplayer.TabIndex = 15;
            this.UsernameDisplayer.Text = "user";
            this.UsernameDisplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashTitle
            // 
            this.DashTitle.AutoSize = true;
            this.DashTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.DashTitle.Location = new System.Drawing.Point(66, 69);
            this.DashTitle.Name = "DashTitle";
            this.DashTitle.Size = new System.Drawing.Size(147, 31);
            this.DashTitle.TabIndex = 17;
            this.DashTitle.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(125, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ADMIN";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1420, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DashTitle);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.UsernameDisplayer);
            this.Controls.Add(this.SideMenu);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SideMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuBook;
        private System.Windows.Forms.ToolStripMenuItem MyBookingsMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuProfile;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Label UsernameDisplayer;
        private System.Windows.Forms.Label DashTitle;
        private System.Windows.Forms.Label label1;
    }
}