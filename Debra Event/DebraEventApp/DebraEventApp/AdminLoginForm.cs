using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebraEventApp
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }



        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtAdminLoginEmail.Text;
            password = txtAdminLoginPassword.Text;
            if (username == "admin" && password == "debra")
            {
                MessageBox.Show("Login Successful");

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Close();
            }
            else
                MessageBox.Show("Failed to Login");  
        }




        private void btnAdminMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdminLoginLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
