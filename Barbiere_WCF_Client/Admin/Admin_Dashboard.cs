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

namespace Barbiere_WCF_Client.Admin
{
    public partial class Admin_Dashboard : Form
    {
        string user = Barbiere.UserTitle;
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // The username is showed in the form
            UsernameDisplayer.Text = user;
        }

        public void hidePanels()
        {
            BookPanel.Visible = false;
            MyBookingsPanel.Visible = false;
            ProfilePanel.Visible = false;
        }

        private void MenuBook_Click(object sender, EventArgs e)
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
        private void AllBookingsMenu_Click(object sender, EventArgs e)
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
                    using (SqlCommand ViewBookings = new SqlCommand("SELECT * FROM Prenotazioni WHERE Data > CAST(GETDATE() AS DATE)", sqlCon))
                    {
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

        private void MenuProfile_Click(object sender, EventArgs e)
        {
            hidePanels();
            ProfilePanel.Visible = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordBox.Text == "" && NewPasswordBoxConfirm.Text == "" && NewUserBox.Text == "" && OldPasswordBox.Text == "")
            {
                MessageBox.Show("Are you sure you're in the right place?");
                NewPasswordBox.Focus();
            }
            // First i check if the passwords match
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
            if (OldPasswordBox.Text != null && (NewUserBox.Text != null || NewPasswordBox.Text != null))
            {
                try
                {
                    // The passwords will be hashed trough EasyEncryption, via the MD5 protocol
                    string OldHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(OldPasswordBox.Text);
                    string NewHashedPassword = "";
                    if (NewPasswordBox.Text != "")
                    {
                        NewHashedPassword = EasyEncryption.MD5.ComputeMD5Hash(NewPasswordBox.Text);
                    }
                    client.UserPasswordChange(NewUserBox.Text, NewHashedPassword, CurrentUserBox.Text, OldHashedPassword);
                    MessageBox.Show("Information changed!");
                    if (NewUserBox.Text != "" && OldPasswordBox.Text != "")
                    {
                        UsernameDisplayer.Text = NewUserBox.Text;
                    }
                }
                catch (Exception yu)
                {
                    MessageBox.Show(yu.ToString());
                }
            }
        }
        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Barbiere logreg = new Barbiere();
            this.Hide();
            logreg.ShowDialog();
        }

        
    }
}

