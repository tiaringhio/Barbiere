namespace Barbiere_WCF_Client.Cliente {
    partial class Password_Recovery {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Recovery));
            this.PasswordRecoveryUser = new System.Windows.Forms.TextBox();
            this.PasswordRecoveryNew = new System.Windows.Forms.TextBox();
            this.PasswordRecoveryNewConfirm = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.BackToLogin = new System.Windows.Forms.LinkLabel();
            this.PasswordRecoveryTitle = new System.Windows.Forms.Label();
            this.PasswordRecoveryButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordRecoveryUser
            // 
            this.PasswordRecoveryUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRecoveryUser.Location = new System.Drawing.Point(525, 159);
            this.PasswordRecoveryUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordRecoveryUser.Multiline = true;
            this.PasswordRecoveryUser.Name = "PasswordRecoveryUser";
            this.PasswordRecoveryUser.Size = new System.Drawing.Size(250, 45);
            this.PasswordRecoveryUser.TabIndex = 1;
            // 
            // PasswordRecoveryNew
            // 
            this.PasswordRecoveryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRecoveryNew.Location = new System.Drawing.Point(525, 245);
            this.PasswordRecoveryNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordRecoveryNew.Multiline = true;
            this.PasswordRecoveryNew.Name = "PasswordRecoveryNew";
            this.PasswordRecoveryNew.PasswordChar = '*';
            this.PasswordRecoveryNew.Size = new System.Drawing.Size(250, 45);
            this.PasswordRecoveryNew.TabIndex = 2;
            // 
            // PasswordRecoveryNewConfirm
            // 
            this.PasswordRecoveryNewConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRecoveryNewConfirm.Location = new System.Drawing.Point(525, 330);
            this.PasswordRecoveryNewConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordRecoveryNewConfirm.Multiline = true;
            this.PasswordRecoveryNewConfirm.Name = "PasswordRecoveryNewConfirm";
            this.PasswordRecoveryNewConfirm.PasswordChar = '*';
            this.PasswordRecoveryNewConfirm.Size = new System.Drawing.Size(250, 45);
            this.PasswordRecoveryNewConfirm.TabIndex = 3;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.Control;
            this.User.Location = new System.Drawing.Point(369, 164);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(84, 37);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.NewPassword.Location = new System.Drawing.Point(264, 250);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(231, 37);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "New Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmPassword.Location = new System.Drawing.Point(228, 334);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(280, 37);
            this.ConfirmPassword.TabIndex = 1;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Panel.Controls.Add(this.BackToLogin);
            this.Panel.Controls.Add(this.PasswordRecoveryTitle);
            this.Panel.Controls.Add(this.PasswordRecoveryButton);
            this.Panel.Controls.Add(this.ConfirmPassword);
            this.Panel.Controls.Add(this.NewPassword);
            this.Panel.Controls.Add(this.User);
            this.Panel.Controls.Add(this.PasswordRecoveryNewConfirm);
            this.Panel.Controls.Add(this.PasswordRecoveryNew);
            this.Panel.Controls.Add(this.PasswordRecoveryUser);
            this.Panel.Location = new System.Drawing.Point(354, 208);
            this.Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1034, 553);
            this.Panel.TabIndex = 2;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.LinkColor = System.Drawing.SystemColors.Control;
            this.BackToLogin.Location = new System.Drawing.Point(852, 261);
            this.BackToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(136, 25);
            this.BackToLogin.TabIndex = 32;
            this.BackToLogin.TabStop = true;
            this.BackToLogin.Text = "Back to login";
            this.BackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack);
            // 
            // PasswordRecoveryTitle
            // 
            this.PasswordRecoveryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PasswordRecoveryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRecoveryTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordRecoveryTitle.Location = new System.Drawing.Point(200, 59);
            this.PasswordRecoveryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordRecoveryTitle.Name = "PasswordRecoveryTitle";
            this.PasswordRecoveryTitle.Size = new System.Drawing.Size(662, 62);
            this.PasswordRecoveryTitle.TabIndex = 31;
            this.PasswordRecoveryTitle.Text = "Password Recovery";
            this.PasswordRecoveryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordRecoveryButton
            // 
            this.PasswordRecoveryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PasswordRecoveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PasswordRecoveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordRecoveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRecoveryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordRecoveryButton.Location = new System.Drawing.Point(426, 438);
            this.PasswordRecoveryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordRecoveryButton.Name = "PasswordRecoveryButton";
            this.PasswordRecoveryButton.Size = new System.Drawing.Size(204, 53);
            this.PasswordRecoveryButton.TabIndex = 4;
            this.PasswordRecoveryButton.Text = "Recover";
            this.PasswordRecoveryButton.UseVisualStyleBackColor = false;
            this.PasswordRecoveryButton.Click += new System.EventHandler(this.PasswordRecoveryButton_Click);
            // 
            // Password_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::Barbiere_WCF_Client.Properties.Resources.bg_dash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1700, 969);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Password_Recovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.Password_Recovery_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordRecoveryUser;
        private System.Windows.Forms.TextBox PasswordRecoveryNew;
        private System.Windows.Forms.TextBox PasswordRecoveryNewConfirm;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button PasswordRecoveryButton;
        private System.Windows.Forms.Label PasswordRecoveryTitle;
        private System.Windows.Forms.LinkLabel BackToLogin;
    }
}