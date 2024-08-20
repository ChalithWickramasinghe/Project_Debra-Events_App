using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nancy.Json;

namespace DebraEventApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string url = "https://localhost:7267/api/Partner";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            String json = client.DownloadString(url);
        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Partner";
            HttpClient httpClient = new HttpClient();
            Partner partner = new Partner();
            partner.Name = txtRegisterName.Text;
            partner.Email = txtRegisterEmail.Text;
            partner.Password = txtRegisterPassword.Text;
            string Data = (new JavaScriptSerializer()).Serialize(partner);
            var connect = new StringContent(Data, UnicodeEncoding.UTF8,"application/json");
            var res = httpClient.PostAsync(url, connect).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Registerd Successfully");
                LoadData();

                {
                    LoginForm LF = new LoginForm();
                    LF.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Failed to Register");

            
        }

        private void btnMainMenuRegister_Click(object sender, EventArgs e)
        {
            MainForm loginForm = new MainForm();
            loginForm.Show();
            this.Hide();
        }

        class Partner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; } = string.Empty;


        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
