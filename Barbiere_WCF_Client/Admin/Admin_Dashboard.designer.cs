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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.SideMenu = new System.Windows.Forms.MenuStrip();
            this.MenuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.AllBookingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.UsernameDisplayer = new System.Windows.Forms.Label();
            this.DashTitle = new System.Windows.Forms.Label();
            this.AdminLabelMenu = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBoxConfirm = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.CurrentUserBox = new System.Windows.Forms.TextBox();
            this.NewUserBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.CurrentUsername = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.NewUsername = new System.Windows.Forms.Label();
            this.ProfileTitle = new System.Windows.Forms.Label();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.MyBookingsPanel = new System.Windows.Forms.Panel();
            this.MyBookingsTable = new System.Windows.Forms.DataGridView();
            this.MyBookingsTitle = new System.Windows.Forms.Label();
            this.BookingButton = new System.Windows.Forms.Button();
            this.TitoloPanelPrenota = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SideMenu.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.MyBookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyBookingsTable)).BeginInit();
            this.BookPanel.SuspendLayout();
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
            this.AllBookingsMenu,
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
            this.MenuBook.Click += new System.EventHandler(this.BookMenu);
            // 
            // AllBookingsMenu
            // 
            this.AllBookingsMenu.AutoSize = false;
            this.AllBookingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.AllBookingsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBookingsMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.AllBookingsMenu.Name = "AllBookingsMenu";
            this.AllBookingsMenu.Size = new System.Drawing.Size(307, 75);
            this.AllBookingsMenu.Text = "All Bookings";
            this.AllBookingsMenu.Click += new System.EventHandler(this.MyBookings);
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
            this.MenuProfile.Click += new System.EventHandler(this.ProfileMenu);
            // 
            // LogOutLink
            // 
            this.LogOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LogOutLink.LinkColor = System.Drawing.SystemColors.Control;
            this.LogOutLink.Location = new System.Drawing.Point(0, 644);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(316, 16);
            this.LogOutLink.TabIndex = 16;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log-Out";
            this.LogOutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut);
            // 
            // UsernameDisplayer
            // 
            this.UsernameDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UsernameDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameDisplayer.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameDisplayer.Location = new System.Drawing.Point(0, 688);
            this.UsernameDisplayer.Name = "UsernameDisplayer";
            this.UsernameDisplayer.Size = new System.Drawing.Size(316, 30);
            this.UsernameDisplayer.TabIndex = 15;
            this.UsernameDisplayer.Text = "user";
            this.UsernameDisplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashTitle
            // 
            this.DashTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.DashTitle.Location = new System.Drawing.Point(0, 71);
            this.DashTitle.Name = "DashTitle";
            this.DashTitle.Size = new System.Drawing.Size(316, 50);
            this.DashTitle.TabIndex = 17;
            this.DashTitle.Text = "Dashboard";
            this.DashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminLabelMenu
            // 
            this.AdminLabelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminLabelMenu.Location = new System.Drawing.Point(2, 510);
            this.AdminLabelMenu.Name = "AdminLabelMenu";
            this.AdminLabelMenu.Size = new System.Drawing.Size(316, 25);
            this.AdminLabelMenu.TabIndex = 18;
            this.AdminLabelMenu.Text = "ADMIN";
            this.AdminLabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeButton.Location = new System.Drawing.Point(665, 213);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(136, 34);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.UserChange);
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(423, 316);
            this.OldPasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldPasswordBox.Multiline = true;
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '*';
            this.OldPasswordBox.Size = new System.Drawing.Size(137, 30);
            this.OldPasswordBox.TabIndex = 4;
            // 
            // NewPasswordBoxConfirm
            // 
            this.NewPasswordBoxConfirm.Location = new System.Drawing.Point(423, 255);
            this.NewPasswordBoxConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPasswordBoxConfirm.Multiline = true;
            this.NewPasswordBoxConfirm.Name = "NewPasswordBoxConfirm";
            this.NewPasswordBoxConfirm.PasswordChar = '*';
            this.NewPasswordBoxConfirm.Size = new System.Drawing.Size(137, 30);
            this.NewPasswordBoxConfirm.TabIndex = 3;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(423, 207);
            this.NewPasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPasswordBox.Multiline = true;
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '*';
            this.NewPasswordBox.Size = new System.Drawing.Size(137, 30);
            this.NewPasswordBox.TabIndex = 2;
            // 
            // CurrentUserBox
            // 
            this.CurrentUserBox.Location = new System.Drawing.Point(423, 113);
            this.CurrentUserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentUserBox.Multiline = true;
            this.CurrentUserBox.Name = "CurrentUserBox";
            this.CurrentUserBox.Size = new System.Drawing.Size(137, 30);
            this.CurrentUserBox.TabIndex = 1;
            // 
            // NewUserBox
            // 
            this.NewUserBox.Location = new System.Drawing.Point(423, 159);
            this.NewUserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewUserBox.Multiline = true;
            this.NewUserBox.Name = "NewUserBox";
            this.NewUserBox.Size = new System.Drawing.Size(137, 30);
            this.NewUserBox.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(234, 316);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmPassword.Location = new System.Drawing.Point(175, 255);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.ConfirmPassword.TabIndex = 1;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // CurrentUsername
            // 
            this.CurrentUsername.AutoSize = true;
            this.CurrentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentUsername.Location = new System.Drawing.Point(172, 113);
            this.CurrentUsername.Name = "CurrentUsername";
            this.CurrentUsername.Size = new System.Drawing.Size(140, 20);
            this.CurrentUsername.TabIndex = 1;
            this.CurrentUsername.Text = "Current Username";
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.NewPassword.Location = new System.Drawing.Point(199, 207);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(113, 20);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "New Password";
            // 
            // NewUsername
            // 
            this.NewUsername.AutoSize = true;
            this.NewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.NewUsername.Location = new System.Drawing.Point(194, 159);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(118, 20);
            this.NewUsername.TabIndex = 1;
            this.NewUsername.Text = "New Username";
            // 
            // ProfileTitle
            // 
            this.ProfileTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.ProfileTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.ProfileTitle.Location = new System.Drawing.Point(0, 40);
            this.ProfileTitle.Name = "ProfileTitle";
            this.ProfileTitle.Size = new System.Drawing.Size(900, 50);
            this.ProfileTitle.TabIndex = 0;
            this.ProfileTitle.Text = "My Profile";
            this.ProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ProfilePanel.Controls.Add(this.ChangeButton);
            this.ProfilePanel.Controls.Add(this.OldPasswordBox);
            this.ProfilePanel.Controls.Add(this.NewPasswordBoxConfirm);
            this.ProfilePanel.Controls.Add(this.NewPasswordBox);
            this.ProfilePanel.Controls.Add(this.CurrentUserBox);
            this.ProfilePanel.Controls.Add(this.NewUserBox);
            this.ProfilePanel.Controls.Add(this.Password);
            this.ProfilePanel.Controls.Add(this.ConfirmPassword);
            this.ProfilePanel.Controls.Add(this.CurrentUsername);
            this.ProfilePanel.Controls.Add(this.NewPassword);
            this.ProfilePanel.Controls.Add(this.NewUsername);
            this.ProfilePanel.Controls.Add(this.ProfileTitle);
            this.ProfilePanel.Location = new System.Drawing.Point(418, 197);
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(900, 400);
            this.ProfilePanel.TabIndex = 19;
            this.ProfilePanel.Visible = false;
            // 
            // MyBookingsPanel
            // 
            this.MyBookingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MyBookingsPanel.Controls.Add(this.MyBookingsTable);
            this.MyBookingsPanel.Controls.Add(this.MyBookingsTitle);
            this.MyBookingsPanel.Location = new System.Drawing.Point(418, 197);
            this.MyBookingsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyBookingsPanel.Name = "MyBookingsPanel";
            this.MyBookingsPanel.Size = new System.Drawing.Size(900, 400);
            this.MyBookingsPanel.TabIndex = 19;
            // 
            // MyBookingsTable
            // 
            this.MyBookingsTable.AllowUserToAddRows = false;
            this.MyBookingsTable.AllowUserToDeleteRows = false;
            this.MyBookingsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MyBookingsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyBookingsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyBookingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MyBookingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyBookingsTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyBookingsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.MyBookingsTable.GridColor = System.Drawing.SystemColors.Control;
            this.MyBookingsTable.Location = new System.Drawing.Point(169, 128);
            this.MyBookingsTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyBookingsTable.Name = "MyBookingsTable";
            this.MyBookingsTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyBookingsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MyBookingsTable.RowHeadersVisible = false;
            this.MyBookingsTable.RowHeadersWidth = 51;
            this.MyBookingsTable.RowTemplate.Height = 24;
            this.MyBookingsTable.Size = new System.Drawing.Size(577, 150);
            this.MyBookingsTable.TabIndex = 3;
            // 
            // MyBookingsTitle
            // 
            this.MyBookingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.MyBookingsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.MyBookingsTitle.Location = new System.Drawing.Point(0, 40);
            this.MyBookingsTitle.Name = "MyBookingsTitle";
            this.MyBookingsTitle.Size = new System.Drawing.Size(900, 50);
            this.MyBookingsTitle.TabIndex = 0;
            this.MyBookingsTitle.Text = "My Bookings";
            this.MyBookingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookingButton
            // 
            this.BookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BookingButton.Location = new System.Drawing.Point(352, 284);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(200, 44);
            this.BookingButton.TabIndex = 3;
            this.BookingButton.Text = "Book";
            this.BookingButton.UseVisualStyleBackColor = false;
            this.BookingButton.Click += new System.EventHandler(this.Book);
            // 
            // TitoloPanelPrenota
            // 
            this.TitoloPanelPrenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitoloPanelPrenota.ForeColor = System.Drawing.SystemColors.Control;
            this.TitoloPanelPrenota.Location = new System.Drawing.Point(0, 40);
            this.TitoloPanelPrenota.Name = "TitoloPanelPrenota";
            this.TitoloPanelPrenota.Size = new System.Drawing.Size(900, 50);
            this.TitoloPanelPrenota.TabIndex = 10;
            this.TitoloPanelPrenota.Text = "Book an appointment";
            this.TitoloPanelPrenota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.ForeColor = System.Drawing.SystemColors.Control;
            this.Hour.Location = new System.Drawing.Point(301, 217);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(44, 20);
            this.Hour.TabIndex = 10;
            this.Hour.Text = "Hour";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.Control;
            this.Date.Location = new System.Drawing.Point(301, 144);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 20);
            this.Date.TabIndex = 10;
            this.Date.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "ddd dd MMM";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(407, 142);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePicker.MinDate = new System.DateTime(2019, 8, 25, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2019, 8, 25, 0, 0, 0, 0);
            // 
            // TimePicker
            // 
            this.TimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TimePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(407, 217);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimePicker.MinDate = new System.DateTime(2019, 8, 25, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 2;
            this.TimePicker.Value = new System.DateTime(2019, 8, 25, 15, 31, 40, 0);
            // 
            // BookPanel
            // 
            this.BookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BookPanel.Controls.Add(this.label1);
            this.BookPanel.Controls.Add(this.BookingButton);
            this.BookPanel.Controls.Add(this.TitoloPanelPrenota);
            this.BookPanel.Controls.Add(this.Hour);
            this.BookPanel.Controls.Add(this.Date);
            this.BookPanel.Controls.Add(this.DatePicker);
            this.BookPanel.Controls.Add(this.TimePicker);
            this.BookPanel.Location = new System.Drawing.Point(418, 197);
            this.BookPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookPanel.Name = "BookPanel";
            this.BookPanel.Size = new System.Drawing.Size(900, 400);
            this.BookPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(404, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mon-Sun (9-19)";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::Barbiere_WCF_Client.Properties.Resources.bg_dash;
            this.ClientSize = new System.Drawing.Size(1420, 785);
            this.Controls.Add(this.BookPanel);
            this.Controls.Add(this.MyBookingsPanel);
            this.Controls.Add(this.AdminLabelMenu);
            this.Controls.Add(this.DashTitle);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.UsernameDisplayer);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.ProfilePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(418, 197);
            this.MaximizeBox = false;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.MyBookingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyBookingsTable)).EndInit();
            this.BookPanel.ResumeLayout(false);
            this.BookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip SideMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuBook;
        private System.Windows.Forms.ToolStripMenuItem AllBookingsMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuProfile;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Label UsernameDisplayer;
        private System.Windows.Forms.Label DashTitle;
        private System.Windows.Forms.Label AdminLabelMenu;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.TextBox NewPasswordBoxConfirm;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.TextBox CurrentUserBox;
        private System.Windows.Forms.TextBox NewUserBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Label CurrentUsername;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Label NewUsername;
        private System.Windows.Forms.Label ProfileTitle;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label TitoloPanelPrenota;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Panel BookPanel;
        private System.Windows.Forms.Panel MyBookingsPanel;
        private System.Windows.Forms.DataGridView MyBookingsTable;
        private System.Windows.Forms.Label MyBookingsTitle;
        private System.Windows.Forms.Label label1;
    }
}