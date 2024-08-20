using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebraEventApp
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAdminDashViewEvent_Click(object sender, EventArgs e)
        {
            AdminEventView adminEventView = new AdminEventView();
            adminEventView.Show();
            this.Hide();
        }

        private void btnAdminDashViewTicket_Click(object sender, EventArgs e)
        {
            AdminViewTicket adminViewTicket = new AdminViewTicket();
            adminViewTicket.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnMainMenuAdminDashboard_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

        }

        private void btnLogoutAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
