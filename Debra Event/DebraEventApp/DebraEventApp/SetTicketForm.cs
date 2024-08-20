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


namespace DebraEventApp
{
    public partial class SetTicketForm : Form
    {
        int id = 0;

        public SetTicketForm()
        {
            InitializeComponent();
        }

        private void SetTicketForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPreviousSetTicket_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }


        private void LoadData()
        {
            string url = "https://localhost:7267/api/Ticket";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);
            dgvTicket.DataSource = null;
            dgvTicket.DataSource = (new JavaScriptSerializer()).
                Deserialize<List<Ticket>>(json);
        }


  

        private void btnTicketCreate_Click(object sender, EventArgs e)
            {
                string url = "https://localhost:7267/api/Ticket";
                HttpClient httpClient = new HttpClient();
                Ticket ticket = new Ticket();
                ticket.Id = id;
                ticket.Title = txtTicketEventName.Text;
                ticket.Price = Convert.ToDecimal(txtTicketPrice.Text);
                ticket.IsSold = true;
                ticket.IsSold = false;
      //        ticket.Commission = Convert.ToDecimal(txtTicketCommision.Text);
                ticket.SaleDate = DateTime.Now;
                string data = (new JavaScriptSerializer()).Serialize(ticket);
                var connect = new StringContent(data, Encoding.UTF8, "application/json");
                var res = httpClient.PostAsync(url, connect).Result;
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ticket Added Successfully");
                    LoadData();
                }
                else
                    MessageBox.Show("Faild to Add Ticket");
            }


        





        class Ticket
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public bool IsSold { get; set; }
           // public decimal Commission { get; set; }
            public DateTime? SaleDate { get; set; }

        }





        private void btnTicketUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.Title = txtTicketEventName.Text;
            ticket.Price = Convert.ToDecimal(txtTicketPrice.Text);
            ticket.IsSold = true;
            ticket.IsSold = false;
      //    ticket.Commission = Convert.ToDecimal(txtTicketCommision.Text);
            ticket.SaleDate = DateTime.Now;


            string data = (new JavaScriptSerializer().Serialize(ticket));
            var connect = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var res = httpClient.PutAsync(url, connect).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Update Successfully");
                LoadData();
            }
            else
                MessageBox.Show("Fail to Update");

        }






        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (col==0)
            {
                txtTicketID.Text = dgvTicket.Rows[row].Cells[1].Value.ToString();
                txtTicketEventName.Text = dgvTicket.Rows[row].Cells[2].Value.ToString();
                txtTicketPrice.Text = dgvTicket.Rows[row].Cells[3].Value.ToString();
                txtTicketsSold.Text = dgvTicket.Rows[row].Cells[4].Value.ToString();
          //    txtTicketCommision.Text = dgvTicket.Rows[row].Cells[5].Value.ToString();
                txtTicketDate.Text = dgvTicket.Rows[row].Cells[5].Value.ToString();

                id = Convert.ToInt32(dgvTicket.Rows[row].Cells[1].Value.ToString());
            }
        }

        private void btnTicketDelete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Delete Ticket",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var res = httpClient.DeleteAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    LoadData();
                    txtTicketID.Clear();
                    txtTicketEventName.Clear();
                    txtTicketPrice.Clear();
                    txtTicketsSold.Clear();
             //     txtTicketCommision.Clear();
                    txtTicketDate.Clear();
                }
            
            }
        }

        private void btnReleaseTicket_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.IsSold = true;
            string data =(new JavaScriptSerializer()).Serialize(ticket);
            var connect = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var res = httpClient.PostAsync(url, connect).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Tickets Are Release to the Market");
                LoadData();
            }
            else
            
                MessageBox.Show("Failed to Release");
            
        }


        private void btnTicketUpdate_Click_1(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.Title = txtTicketEventName.Text;
            ticket.Price = Convert.ToDecimal(txtTicketPrice.Text);
            ticket.IsSold = true;
            ticket.IsSold = false;
            ticket.SaleDate = DateTime.Now;

            string data = (new JavaScriptSerializer()).Serialize(ticket);
            var connect = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var res = httpClient.PutAsync(url, connect).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket Updated");
                LoadData();
            }
            else
                MessageBox.Show("Updated Fail");
        }



    }
}
