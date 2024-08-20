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


    public partial class AdminViewTicket : Form
    {

        int id = 0;
        public AdminViewTicket()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string url = "https://localhost:7267/api/Ticket";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);
            dgvAdminTicketView.DataSource = null;
            dgvAdminTicketView.DataSource = (new JavaScriptSerializer()).
                Deserialize<List<Ticket>>(json);
        }

        private void btnAdminPreviousViewTicket_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void dgvAdminTicketView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                txtAdminTicketID.Text = dgvAdminTicketView.Rows[row].Cells[1].Value.ToString();
                txtAdminTicketEventName.Text = dgvAdminTicketView.Rows[row].Cells[2].Value.ToString();
                txtAdminTicketPrice.Text = dgvAdminTicketView.Rows[row].Cells[3].Value.ToString();
                txtAdminTicketsSold.Text = dgvAdminTicketView.Rows[row].Cells[4].Value.ToString();
                txtAdminTicketCommision.Text = dgvAdminTicketView.Rows[row].Cells[5].Value.ToString();
                txtAdminTicketDate.Text = dgvAdminTicketView.Rows[row].Cells[6].Value.ToString();

                id = Convert.ToInt32(dgvAdminTicketView.Rows[row].Cells[1].Value.ToString());
            }
        }

        class Ticket
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public bool IsSold { get; set; }
            public decimal Commission { get; set; }
            public DateTime? SaleDate { get; set; }

        }

        private void AdminViewTicket_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btnAdminTicketUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.Title = txtAdminTicketEventName.Text;
            ticket.Price = Convert.ToDecimal(txtAdminTicketPrice.Text);
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




        private void btnAdminTicketDelete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/Ticket/" + id;
            HttpClient httpClient = new HttpClient();
            DialogResult result = MessageBox.Show("Are you sure you want to remove?", "Remove Ticket",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var res = httpClient.DeleteAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    LoadData();
;                   txtAdminTicketID.Clear();
                    txtAdminTicketEventName.Clear();
                    txtAdminTicketPrice.Clear();
                    txtAdminTicketsSold.Clear();
                    txtAdminTicketDate.Clear();
                    txtAdminTicketCommision.Clear();
                }
            }
        }


    }
}
