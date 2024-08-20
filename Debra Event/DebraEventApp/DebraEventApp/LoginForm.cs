using Nancy.Json;
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
using static DebraEventApp.LoginForm;

namespace DebraEventApp
{
    public partial class LoginForm : Form
    {
        int id = 0;
        public LoginForm()
        {
            InitializeComponent();
        }






        private void LoadData()
        {
            string url = "https://localhost:7267/api/Partner/login";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
        }





        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Partner/login";
            HttpClient httpClient = new HttpClient();
            Login login = new Login();
            login.Email = txtLoginEmail.Text;
            login.Password = txtLoginPassword.Text;
            string Data = (new JavaScriptSerializer()).Serialize(login);
            var connect = new StringContent(Data, UnicodeEncoding.UTF8, "application/json");
            var res = httpClient.PostAsync(url, connect).Result;

            if (res.IsSuccessStatusCode)
            {

                MessageBox.Show("Login Successfully");

                var responsContent = res.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                Login responseLogin = jsSerializer.Deserialize<Login>(responsContent);

                DashboardForm dashboardForm = new DashboardForm(responseLogin.id);
                //dashboardForm.PID = id;
                dashboardForm.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Failed to Login");
        }




        class Login
        {
            public string Email { get; set; }
            public string Password { get; set; } = string.Empty;
            public int id { get; set; }
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class PartnerLoginAccess
        {
            //public int id { get; set; }
        }

        private void btnLoginRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    } }
