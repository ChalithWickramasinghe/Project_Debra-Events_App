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
    public partial class AdminEventView : Form
    {

        int id = 0;
        public AdminEventView()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string url = "https://localhost:7267/api/AddEvent";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);
            dgvAdminEventView.DataSource = null;
            dgvAdminEventView.DataSource = (new JavaScriptSerializer()).
                Deserialize<List<AddEvent>>(json);
        }

        class AddEvent
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public DateTime? Date { get; set; }
            public int PartnerId { get; set; }


        }

        public void loadAdminEventView(int id)
        {
            string url = "https://localhost:7267/api/AddEvent/partner/" + id;
            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(url).Result;
                if (!string.IsNullOrEmpty(response))
                {
                    var createEventForm = new JavaScriptSerializer().Deserialize<List<AddEvent>>(response);
                    dgvAdminEventView.DataSource = createEventForm;
                }
                else
                {
                    dgvAdminEventView.DataSource = null;
                }
            }
        }


        private void txtEventDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviousNewEvent_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnEventCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtEventVenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEventPartnerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminEventView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAdminEventView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                txtAdminEventID.Text = dgvAdminEventView.Rows[row].Cells[1].Value.ToString();
                txtAdminEventName.Text = dgvAdminEventView.Rows[row].Cells[2].Value.ToString();
                txtAdminEventDescription.Text = dgvAdminEventView.Rows[row].Cells[3].Value.ToString();
                txtAdminEventVenue.Text = dgvAdminEventView.Rows[row].Cells[4].Value.ToString();
                txtAdminEventDate.Text = dgvAdminEventView.Rows[row].Cells[5].Value.ToString();
                txtAdminEventPartnerID.Text = dgvAdminEventView.Rows[row].Cells[6].Value.ToString();

                id = Convert.ToInt32(dgvAdminEventView.Rows[row].Cells[1].Value.ToString());
            }
        }



        private void btnAdminEventUpdate_Click(object sender, EventArgs e)
        {
            {
                string url = "https://localhost:7267/api/AddEvent/" + id;
                HttpClient httpClient = new HttpClient();
                AddEvent addEvent = new AddEvent();
                addEvent.Id = id;
                addEvent.Name = txtAdminEventName.Text;
                addEvent.Description = txtAdminEventDescription.Text;
                addEvent.Location = txtAdminEventVenue.Text;
                addEvent.Date = DateTime.Now;

                string data = (new JavaScriptSerializer().Serialize(addEvent));
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
        }




        private void btnAdminEventDelete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/AddEvent/" + id;
            HttpClient httpClient = new HttpClient();
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Event",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var res = httpClient.DeleteAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    LoadData();
                    txtAdminEventID.Clear();
                    txtAdminEventName.Clear();
                    txtAdminEventDescription.Clear();
                    txtAdminEventDate.Clear();
                    txtAdminEventVenue.Clear();
                    
                }
            }
        }


    }
}
