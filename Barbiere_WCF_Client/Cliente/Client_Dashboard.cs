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

namespace Barbiere_WCF_Client.Cliente {
    public partial class Client_Dashboard : Form {
        string user = Barbiere.UserTitle;
        public void hidePanels()
        {
            BookPanel.Visible = false;
            MyBookingsPanel.Visible = false;
            ProfilePanel.Visible = false;
        }
        public Client_Dashboard()
        {
            InitializeComponent();
        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Mostro lo username dell'utente loggato
            UsernameDisplayer.Text = user;
        }
        private void MenuPrenota_Click(object sender, EventArgs e)
        {
            hidePanels();
            BookPanel.Visible = true;
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.AddBooking(user, DatePicker.Value, TimePicker.Value);
                MessageBox.Show("olè");
                    MessageBox.Show("Ci vediamo " + DatePicker.Text + " alle ore: " + TimePicker.Text + "!");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }

        }

        private void MenuMiePrenotazioni_Click(object sender, EventArgs e)
        {
            // I hide every panel except for the My Bookings one
            hidePanels();
            MyBookingsPanel.Visible = true;
            // This stored procedure reads the data from the db and displays them in a DataGridview
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlCon.Open();
                    using (SqlCommand ViewBookings = new SqlCommand("ViewBookings", sqlCon))
                    {
                        ViewBookings.CommandType = CommandType.StoredProcedure;
                        ViewBookings.Parameters.AddWithValue("@Utente", UsernameDisplayer.Text);
                        ViewBookings.ExecuteNonQuery();

                        using (SqlDataAdapter datadapter = new SqlDataAdapter(ViewBookings))
                        {
                            DataTable mieprenotazioni = new DataTable();
                            datadapter.Fill(mieprenotazioni);
                            MyBookingsTable.DataSource = mieprenotazioni;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void MenuProfilo_Click(object sender, EventArgs e)
        {
            hidePanels();
            ProfilePanel.Visible = true;
        }
        // This stored procedure allows the user to change username and password
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            // First i check if the passwords match
            if (NewPasswordBox.Text != NewPasswordBoxConfirm.Text )
            {
                MessageBox.Show("Passwords don't match");
                NewPasswordBox.Focus();
                return;
            }
            // Then i check if the boxes are empty and that the new password is secure enough
            else if (NewPasswordBox.Text != "" && NewPasswordBox.Text.Length < 6)
            {
                MessageBox.Show("You need a stronger password, 6 characters are enough");
                NewPasswordBox.Focus();
                return;
            }
            // Finally i execute the stored procedure
            if (OldPasswordBox.Text != null && (NewUserBox.Text != null || NewPasswordBox.Text != null))
            {
                try
                {
                    string OldHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(OldPasswordBox.Text);
                    string NewHashedPassword = "";
                    if (NewPasswordBox.Text != "")
                        NewHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(NewPasswordBox.Text);
                    using (SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        sqlcon.Open();
                        using (SqlCommand UserPasswordChange = new SqlCommand("UserPasswordChange", sqlcon))
                        {
                            UserPasswordChange.CommandType = CommandType.StoredProcedure;
                            UserPasswordChange.Parameters.AddWithValue("@Utente", NewUserBox.Text);
                            UserPasswordChange.Parameters.AddWithValue("@Password", NewHashedPassword);
                            UserPasswordChange.Parameters.AddWithValue("@OldUser", UsernameDisplayer.Text);
                            UserPasswordChange.Parameters.AddWithValue("@OldPassword", OldHashedPassword);
                            UserPasswordChange.ExecuteNonQuery();
                            MessageBox.Show("Confirmed!");
                            return;
                        }
                    }
                }
                catch (Exception exce)
                {
                    exce.ToString();
                }
            }
        }
        // Simple
        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Barbiere logreg = new Barbiere();
            this.Hide();
            logreg.ShowDialog();
        }

        
    }
}
