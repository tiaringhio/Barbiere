using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barbiere_WCF_Client;
using Barbiere_WCF_Client.Cliente;

namespace Barbiere_WCF_Client.Cliente {
    public partial class Password_Recovery : Form {
        public Password_Recovery()
        {
            InitializeComponent();
        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        // At the click of this button the store procedure will change the password, only if the username exist
        private void PasswordRecoveryButton_Click(object sender, EventArgs e)
        {
            // First i check that the TextBoxes are not empty...
            if (PasswordRecoveryUser.Text == "" || PasswordRecoveryNew.Text == "")
            {
                MessageBox.Show("Questi valori sono obbligatori!");
                PasswordRecoveryUser.Focus();
                return;
            }
            // ... and that the password are the same, if thery're not "The Show Must NOT Go On - Freddy Mercury (Probably)"
            else if (PasswordRecoveryNew.Text != PasswordRecoveryNewConfirm.Text)
            {
                MessageBox.Show("Le password non corrisponodono");
                PasswordRecoveryNew.Focus();
                return;
            }
            try
            {
                // Here is where the magi happens, i use the stored procedure to input the data, by using
                // a stored procedure i protect the program from SQLInjection, since everything is parametrized
                // in this stored procedure i update the passord given the user that the client inputs
                // The password will be hashed trough EasyEncryption, via the MD5 protocol
                string HashedPassword = EasyEncryption.MD5.ComputeMD5Hash(PasswordRecoveryNew.Text);
                client.PasswordRecovery(PasswordRecoveryUser.Text, HashedPassword);
                // I show a message to the user letting him/her know that the password has been changed
                MessageBox.Show("Password cambiata con successo, effettua il login");
                // Then i send him/her back to the initial form to login
                Barbiere logreg = new Barbiere();
                this.Hide();
                logreg.ShowDialog();
            }
             catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void BackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // If the user wants to go back without changing anything he can do it
            Barbiere logreg = new Barbiere();
            this.Hide();
            logreg.ShowDialog();
        }
    }
}
