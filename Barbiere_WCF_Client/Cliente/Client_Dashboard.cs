﻿using System;
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
        readonly string user = Barbiere.UserTitle;
        
        public Client_Dashboard()
        {
            InitializeComponent();
        }
        // This function hides every panel
        public void HidePanels()
        {
            BookPanel.Visible = false;
            MyBookingsPanel.Visible = false;
            ProfilePanel.Visible = false;
        }

        // Reference to WCF
        readonly ServiceReference1.Service1Client WCF = new ServiceReference1.Service1Client();

        // On load i need to set some values...
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set minimum date and time in the picker to today and now
            DatePicker.MinDate = DateTime.Today;
            TimePicker.MinDate = DateTime.Parse("9:00");

            // And the maxium dates
            DatePicker.MaxDate = DateTime.Now.AddDays(15);
            TimePicker.MaxDate = DateTime.Parse("19:00");

            // The username is showed in the form
            UsernameDisplayer.Text = user;
        }

        // At click i show the requested panel while hiding the others
        private void BookMenu(object sender, EventArgs e)
        {
            HidePanels();
            BookPanel.Visible = true;
        }
        // When i click the Book button i sent the value to the WCF Service, so they can be stored in the DB
        private void Book(object sender, EventArgs e)
        {
            try
            {
                WCF.AddBooking(user, DatePicker.Value, TimePicker.Value);
                MessageBox.Show("We'll se you " + DatePicker.Text + " At " + TimePicker.Text + "!");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

        // At click i show the requested panel while hiding the others.
        // Also i load the data from the db and fill a DataGridView
        private void MyBookings(object sender, EventArgs e)
        {
            // I hide every panel except for the My Bookings one
            HidePanels();
            MyBookingsPanel.Visible = true;
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
                        // Here is where i fill the DataGridView using a DataAdapter
                        try
                        {
                            using (SqlDataAdapter datadapter = new SqlDataAdapter(ViewBookings))
                            {
                                DataTable myBookings = new DataTable();
                                datadapter.Fill(myBookings);
                                MyBookingsTable.DataSource = myBookings;
                            }
                        }
                        catch (Exception bookingsException)
                        {
                            MessageBox.Show(bookingsException.ToString());
                        }
                    }
                }
            }
            catch (Exception bookingsException2)
            {
                MessageBox.Show(bookingsException2.ToString());
            }
        }

        // At click i show the requested panel while hiding the others
        private void ProfileMenu(object sender, EventArgs e)
        {
            HidePanels();
            ProfilePanel.Visible = true;
        }
        
        // This Method allows the user to change username or password or both, the data is sent to a WCF
        // service that handles the information with a stored procedure
        private void UserChange(object sender, EventArgs e)
        {
            // First some controls...
            if (NewPasswordBox.Text == "" && NewPasswordBoxConfirm.Text == "" && NewUserBox.Text == "" && OldPasswordBox.Text == "")
            {
                MessageBox.Show("Are you sure you're in the right place?");
                NewPasswordBox.Focus();
            }
            // ... i check if the passwords match
            else if (NewPasswordBox.Text != NewPasswordBoxConfirm.Text)
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
            if (OldPasswordBox.Text == null || (NewUserBox.Text == null && NewPasswordBox.Text == null)) return;
            try
            {
                // The passwords will be hashed trough EasyEncryption, via the MD5 protocol
                string OldHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(OldPasswordBox.Text);
                string NewHashedPassword = "";
                if (NewPasswordBox.Text != "")
                {
                    NewHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(NewPasswordBox.Text);
                }
                // I send the data to the WCF Service
                try
                {
                    WCF.UserPasswordChange(NewUserBox.Text, NewHashedPassword, CurrentUserBox.Text, OldHashedPassword);
                    MessageBox.Show("Information changed!");
                    if (NewUserBox.Text != "" && OldPasswordBox.Text != "")
                    {
                        UsernameDisplayer.Text = NewUserBox.Text;
                    }
                }
                catch (Exception WCFexception)
                {
                    Console.WriteLine(WCFexception);
                    throw;
                }
            }
            catch (Exception changeException)
            {
                MessageBox.Show(changeException.ToString());
            }
        }
        // Simple log out
        private void LogOut(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Barbiere logreg = new Barbiere();
            this.Hide();
            logreg.ShowDialog();
        }
    }
}
