using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Barbiere_WCF_Client.Admin;
using Barbiere_WCF_Client.Cliente;

namespace Barbiere_WCF_Client {
    public partial class Barbiere : Form {

        // This program makes use of Stored Procedures, by using the i make sure that the code is clean
        // while protecting the program from SQLInjection, since everything is parametrized.
        // Created by Mattia Ricci and Mattia Greci


        // I use this string to display the username in the Dashboard
        public static string UserTitle { get; set; }
        public Barbiere()
        {
            InitializeComponent();
        }

        // Reference to WCF
        ServiceReference1.Service1Client WCF = new ServiceReference1.Service1Client();

        // This function clears every textbox
        void Clear()
        {
            NameBox.Text = SurnameBox.Text = UserBoxSign.Text = PasswordBoxSign.Text = PasswordBoxSignConfirm.Text = "";
        }

        // I add in the db the data that the user inputs.
        private void Registration(object sender, EventArgs e)
        {
            // The password will be hashed trough EasyEncryption, via the MD5 protocol
            string HashedPassword = EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxSign.Text);
            // First i check that the TextBoxes are not empty...
            if (UserBoxSign.Text == "" || PasswordBoxSign.Text == "")
            {
                MessageBox.Show("These fields are mandatory!");
                UserBoxSign.Focus();
                PasswordBoxSign.Focus();
            }

            // ... and that the password are the same ...
            else if (PasswordBoxSign.Text != PasswordBoxSignConfirm.Text)
            {
                MessageBox.Show("The passwords don't match'!");
                PasswordBoxSign.Focus();
                return;
            }
            // ... and that the password is secure enough
            else if (PasswordBoxSign.Text.Length < 6)
            {
                MessageBox.Show("You need a stronger password, 6 characters are enough");
                PasswordBoxSign.Focus();
                return;
            }
            // Then i check that the username is available
            try
            {
                // If it's taken i show a message...
                if (!WCF.UserChecker(UserBoxSign.Text)) {
                    MessageBox.Show("Username already taken!");
                    Clear();
                }
                // ... otherwise i let the user register
                else
                {
                    // I send the data to the WCF to be stored in the DB
                    WCF.Registration(NameBox.Text, SurnameBox.Text, UserBoxSign.Text, HashedPassword, AdminCheck.Checked);
                    MessageBox.Show("Registration succeeded, you can now login!");
                    Clear();
                }
            }
            catch (Exception registrationException)
            {
                MessageBox.Show(registrationException.ToString());
                throw;
            }
        }

        // This function allows the user to login
        private void Login(object sender, EventArgs e)
        {
            // The password will be hashed trough EasyEncryption, via the MD5 protocol
            string HashedPassword = EasyEncryption.MD5.ComputeMD5Hash(text: PasswordBoxLog.Text);
            // First i check that the user box is not empy...
            if (UserBoxLog.Text == "")
            {
                MessageBox.Show(text: "You forgot the username!");
                UserBoxLog.Focus();
                return;
            }
            // ... same for the password
            if (PasswordBoxLog.Text == "")
            {
                MessageBox.Show(text: "You forgot the password");
                PasswordBoxLog.Focus();
                return;
            }

            // Then i send the data to the WCF so i can check if user and password are correct
            try
            {
                bool isAdmin = WCF.Login(Utente: UserBoxLog.Text, Password: HashedPassword);
                UserTitle = UserBoxLog.Text;
                // If the user is admin i open the admin dashboard...
                if (isAdmin)
                {
                    Admin_Dashboard admin = new Admin_Dashboard();
                    this.Hide();
                    admin.ShowDialog();
                    UserTitle = UserBoxLog.Text;
                }
                // ... else i open the client dashboard
                else
                {
                    Client_Dashboard client = new Client_Dashboard();
                    this.Hide();
                    client.ShowDialog();
                    UserTitle = UserBoxLog.Text;
                }
            }
            catch (Exception loginException)
            {
                MessageBox.Show(text: "Username or password (or both) are wrong!");
                UserBoxLog.Clear();
                PasswordBoxLog.Clear();
                UserBoxLog.Focus();
                MessageBox.Show(text: loginException.ToString());
            }
        }

        // This is where the user can recover the password
        private void PasswordRecovery(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Password_Recovery recovery = new Password_Recovery();
            recovery.ShowDialog();
        }
    }
}

