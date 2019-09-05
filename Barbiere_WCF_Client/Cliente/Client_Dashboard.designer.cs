namespace Barbiere_WCF_Client.Cliente {
    partial class Client_Dashboard {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsernameDisplayer = new System.Windows.Forms.Label();
            this.DashTitle = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.MenuStrip();
            this.MenuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MyBookingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.BookPanel = new System.Windows.Forms.Panel();
            this.BookingButton = new System.Windows.Forms.Button();
            this.TitoloPanelPrenota = new System.Windows.Forms.Label();
            this.Ora = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBoxConfirm = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.NewUserBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUsername = new System.Windows.Forms.Label();
            this.TitoloProfilo = new System.Windows.Forms.Label();
            this.MyBookingsPanel = new System.Windows.Forms.Panel();
            this.MyBookingsTable = new System.Windows.Forms.DataGridView();
            this.MyBookingsTitle = new System.Windows.Forms.Label();
            this.SideMenu.SuspendLayout();
            this.BookPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.MyBookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyBookingsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameDisplayer
            // 
            this.UsernameDisplayer.AutoSize = true;
            this.UsernameDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UsernameDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameDisplayer.Location = new System.Drawing.Point(132, 673);
            this.UsernameDisplayer.Name = "UsernameDisplayer";
            this.UsernameDisplayer.Size = new System.Drawing.Size(47, 24);
            this.UsernameDisplayer.TabIndex = 6;
            this.UsernameDisplayer.Text = "user";
            this.UsernameDisplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashTitle
            // 
            this.DashTitle.AutoSize = true;
            this.DashTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashTitle.Location = new System.Drawing.Point(68, 71);
            this.DashTitle.Name = "DashTitle";
            this.DashTitle.Size = new System.Drawing.Size(147, 31);
            this.DashTitle.TabIndex = 10;
            this.DashTitle.Text = "Dashboard";
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
            this.SideMenu.TabIndex = 12;
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
            this.MenuBook.Click += new System.EventHandler(this.MenuPrenota_Click);
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
            this.MyBookingsMenu.Click += new System.EventHandler(this.MenuMiePrenotazioni_Click);
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
            this.MenuProfile.Click += new System.EventHandler(this.MenuProfilo_Click);
            // 
            // LogOutLink
            // 
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LogOutLink.LinkColor = System.Drawing.SystemColors.Control;
            this.LogOutLink.Location = new System.Drawing.Point(134, 631);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(55, 16);
            this.LogOutLink.TabIndex = 14;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log-Out";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // BookPanel
            // 
            this.BookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BookPanel.Controls.Add(this.BookingButton);
            this.BookPanel.Controls.Add(this.TitoloPanelPrenota);
            this.BookPanel.Controls.Add(this.Ora);
            this.BookPanel.Controls.Add(this.Data);
            this.BookPanel.Controls.Add(this.DatePicker);
            this.BookPanel.Controls.Add(this.TimePicker);
            this.BookPanel.Location = new System.Drawing.Point(418, 186);
            this.BookPanel.Name = "BookPanel";
            this.BookPanel.Size = new System.Drawing.Size(885, 400);
            this.BookPanel.TabIndex = 15;
            // 
            // BookingButton
            // 
            this.BookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingButton.Location = new System.Drawing.Point(352, 284);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(200, 44);
            this.BookingButton.TabIndex = 3;
            this.BookingButton.Text = "Prenota";
            this.BookingButton.UseVisualStyleBackColor = false;
            // 
            // TitoloPanelPrenota
            // 
            this.TitoloPanelPrenota.AutoSize = true;
            this.TitoloPanelPrenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitoloPanelPrenota.Location = new System.Drawing.Point(272, 57);
            this.TitoloPanelPrenota.Name = "TitoloPanelPrenota";
            this.TitoloPanelPrenota.Size = new System.Drawing.Size(297, 31);
            this.TitoloPanelPrenota.TabIndex = 10;
            this.TitoloPanelPrenota.Text = "Fissa un appuntamento";
            // 
            // Ora
            // 
            this.Ora.AutoSize = true;
            this.Ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ora.Location = new System.Drawing.Point(301, 207);
            this.Ora.Name = "Ora";
            this.Ora.Size = new System.Drawing.Size(48, 26);
            this.Ora.TabIndex = 10;
            this.Ora.Text = "Ora";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(288, 132);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(58, 26);
            this.Data.TabIndex = 10;
            this.Data.Text = "Data";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "ddd dd MMM";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(407, 142);
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
            this.TimePicker.MinDate = new System.DateTime(2019, 8, 25, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 2;
            this.TimePicker.Value = new System.DateTime(2019, 8, 25, 15, 31, 40, 0);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ProfilePanel.Controls.Add(this.ChangeButton);
            this.ProfilePanel.Controls.Add(this.OldPasswordBox);
            this.ProfilePanel.Controls.Add(this.NewPasswordBoxConfirm);
            this.ProfilePanel.Controls.Add(this.NewPasswordBox);
            this.ProfilePanel.Controls.Add(this.NewUserBox);
            this.ProfilePanel.Controls.Add(this.label3);
            this.ProfilePanel.Controls.Add(this.label2);
            this.ProfilePanel.Controls.Add(this.label1);
            this.ProfilePanel.Controls.Add(this.NewUsername);
            this.ProfilePanel.Controls.Add(this.TitoloProfilo);
            this.ProfilePanel.Location = new System.Drawing.Point(415, 189);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(885, 400);
            this.ProfilePanel.TabIndex = 16;
            this.ProfilePanel.Visible = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeButton.Location = new System.Drawing.Point(665, 209);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(136, 34);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(417, 292);
            this.OldPasswordBox.Multiline = true;
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '*';
            this.OldPasswordBox.Size = new System.Drawing.Size(138, 30);
            this.OldPasswordBox.TabIndex = 4;
            // 
            // NewPasswordBoxConfirm
            // 
            this.NewPasswordBoxConfirm.Location = new System.Drawing.Point(417, 230);
            this.NewPasswordBoxConfirm.Multiline = true;
            this.NewPasswordBoxConfirm.Name = "NewPasswordBoxConfirm";
            this.NewPasswordBoxConfirm.PasswordChar = '*';
            this.NewPasswordBoxConfirm.Size = new System.Drawing.Size(138, 30);
            this.NewPasswordBoxConfirm.TabIndex = 3;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(417, 182);
            this.NewPasswordBox.Multiline = true;
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '*';
            this.NewPasswordBox.Size = new System.Drawing.Size(138, 30);
            this.NewPasswordBox.TabIndex = 2;
            // 
            // NewUserBox
            // 
            this.NewUserBox.Location = new System.Drawing.Point(417, 131);
            this.NewUserBox.Multiline = true;
            this.NewUserBox.Name = "NewUserBox";
            this.NewUserBox.Size = new System.Drawing.Size(138, 30);
            this.NewUserBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Password";
            // 
            // NewUsername
            // 
            this.NewUsername.AutoSize = true;
            this.NewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsername.Location = new System.Drawing.Point(167, 131);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(118, 20);
            this.NewUsername.TabIndex = 1;
            this.NewUsername.Text = "New Username";
            // 
            // TitoloProfilo
            // 
            this.TitoloProfilo.AutoSize = true;
            this.TitoloProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.TitoloProfilo.Location = new System.Drawing.Point(345, 46);
            this.TitoloProfilo.Name = "TitoloProfilo";
            this.TitoloProfilo.Size = new System.Drawing.Size(162, 31);
            this.TitoloProfilo.TabIndex = 0;
            this.TitoloProfilo.Text = "Il mio Profilo";
            // 
            // MyBookingsPanel
            // 
            this.MyBookingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MyBookingsPanel.Controls.Add(this.MyBookingsTable);
            this.MyBookingsPanel.Controls.Add(this.MyBookingsTitle);
            this.MyBookingsPanel.Location = new System.Drawing.Point(412, 183);
            this.MyBookingsPanel.Name = "MyBookingsPanel";
            this.MyBookingsPanel.Size = new System.Drawing.Size(885, 400);
            this.MyBookingsPanel.TabIndex = 18;
            // 
            // MyBookingsTable
            // 
            this.MyBookingsTable.AllowUserToAddRows = false;
            this.MyBookingsTable.AllowUserToDeleteRows = false;
            this.MyBookingsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MyBookingsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyBookingsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyBookingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MyBookingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyBookingsTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyBookingsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.MyBookingsTable.GridColor = System.Drawing.SystemColors.Control;
            this.MyBookingsTable.Location = new System.Drawing.Point(169, 128);
            this.MyBookingsTable.Name = "MyBookingsTable";
            this.MyBookingsTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyBookingsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MyBookingsTable.RowHeadersVisible = false;
            this.MyBookingsTable.RowHeadersWidth = 51;
            this.MyBookingsTable.RowTemplate.Height = 24;
            this.MyBookingsTable.Size = new System.Drawing.Size(577, 150);
            this.MyBookingsTable.TabIndex = 3;
            // 
            // MyBookingsTitle
            // 
            this.MyBookingsTitle.AutoSize = true;
            this.MyBookingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.MyBookingsTitle.Location = new System.Drawing.Point(345, 46);
            this.MyBookingsTitle.Name = "MyBookingsTitle";
            this.MyBookingsTitle.Size = new System.Drawing.Size(169, 31);
            this.MyBookingsTitle.TabIndex = 0;
            this.MyBookingsTitle.Text = "My Bookings";
            // 
            // Client_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1420, 785);
            this.Controls.Add(this.MyBookingsPanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.BookPanel);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.UsernameDisplayer);
            this.Controls.Add(this.DashTitle);
            this.Controls.Add(this.SideMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Client_Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.BookPanel.ResumeLayout(false);
            this.BookPanel.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.MyBookingsPanel.ResumeLayout(false);
            this.MyBookingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyBookingsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameDisplayer;
        private System.Windows.Forms.Label DashTitle;
        private System.Windows.Forms.MenuStrip SideMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuBook;
        private System.Windows.Forms.ToolStripMenuItem MyBookingsMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuProfile;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Panel BookPanel;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label TitoloPanelPrenota;
        private System.Windows.Forms.Label Ora;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.TextBox NewPasswordBoxConfirm;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.TextBox NewUserBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewUsername;
        private System.Windows.Forms.Label TitoloProfilo;
        private System.Windows.Forms.Panel MyBookingsPanel;
        private System.Windows.Forms.DataGridView MyBookingsTable;
        private System.Windows.Forms.Label MyBookingsTitle;
    }
}