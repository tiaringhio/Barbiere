using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbiere_WCF_Client.Admin {
    public partial class Admin_Dashboard : Form {
        string user = Barbiere.UserTitle;
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // The username is showed in the form
            UsernameDisplayer.Text = user;
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Barbiere logreg = new Barbiere();
            this.Hide();
            logreg.ShowDialog();
        }
    }
}
