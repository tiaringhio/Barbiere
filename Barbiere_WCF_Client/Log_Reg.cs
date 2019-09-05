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
using Barbiere_WCF_Server;

namespace Barbiere_WCF_Client {
    public partial class Barbiere : Form {
        // La connection string la devi cambiare, perché il percorso è quello del mio disco, vai su Server Explorer (Il menu),
        // right click sul DB, Proprietà, copia la Connection String in modo che sia formattata come la mia, ez pez
        public static string UserTitle { get; set; }
        public Barbiere()
        {
            InitializeComponent();
        }
        // I add the data that the user inputs in the db, using a stored procedure called UserAdd
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            // The password will be hashed trough EasyEncryption, via the MD5 protocol
            string HashedPassword = EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxSign.Text);
            // First i check that the TextBoxes are not empty...
            if (UserBoxSign.Text == "" || PasswordBoxSign.Text == "")
                MessageBox.Show("Questi valori sono obbligatori!");
            // ... and that the password are the same ...
            else if (PasswordBoxSign.Text != PasswordBoxSignConfirm.Text)
            {
                MessageBox.Show("Le password non corrispondono!");
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
                client.Registration(NameBox.Text, SurnameBox.Text, UserBoxSign.Text, HashedPassword, AdminCheck.Checked);
                    MessageBox.Show("Registration succeded, you can now login!");

            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }

        }
        void Clear()
        {
            NameBox.Text = SurnameBox.Text = UserBoxSign.Text = PasswordBoxSign.Text = PasswordBoxSignConfirm.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // The password will be hashed trough EasyEncryption, via the MD5 protocol
            string HashedPassword = EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLog.Text);
            // First i check that the TextBoxes are not empty...
            if (UserBoxLog.Text == "")
            {
                MessageBox.Show("Perfavore inserisci il nome utente");
                UserBoxLog.Focus();
                return;
            }
            else if (PasswordBoxLog.Text == "")
            {
                MessageBox.Show("Perfavore inserisci la password");
                PasswordBoxLog.Focus();
                return;
            }
            try
            {
                Barbiere_WCF_Server.Service1 server = new Barbiere_WCF_Server.Service1();
                
                bool Admin = server.isAdmin;
                if (client.Login(UserBoxLog.Text, HashedPassword, Admin))
                {
                  
                    MessageBox.Show("Bentornato " + UserBoxLog.Text);
                    // bool che controlla se l'utente è admin
                    try
                    {
                        MessageBox.Show("value" + Admin);
                        UserTitle = UserBoxLog.Text;
                        // If the user is admin i open the admin dashboard...
                        if (!Admin)
                        {
                            Client_Dashboard cliente = new Client_Dashboard();
                            this.Hide();
                            cliente.ShowDialog();
                            UserTitle = UserBoxLog.Text;
                        }
                        // ... else i open the client dashboard
                        else
                        {
                            Admin_Dashboard admin = new Admin_Dashboard();
                            this.Hide();
                            admin.ShowDialog();
                            UserTitle = UserBoxLog.Text;
                            
                        }
                    }
                    catch (Exception gne)
                    {
                        MessageBox.Show(gne.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
            }
        }
        // When the user clicks on password recovery i open a form when he can reset the password, given the username
        private void PasswordRecoveryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Password_Recovery recovery = new Password_Recovery();
            recovery.ShowDialog();
        }
    }
}
