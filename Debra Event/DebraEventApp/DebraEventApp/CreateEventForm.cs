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
    public partial class CreateEventForm : Form
    {

        int id = 0;
        public List<CreateEventForm> events = new List<CreateEventForm>();

        public CreateEventForm(int idPartner)
        {
            InitializeComponent();
            id = idPartner;

            txtEventPartnerID.Text = idPartner.ToString();
            loadCreateEventForm(id);
        }

        public void loadCreateEventForm(int id)
        {
            string url = "https://localhost:7267/api/AddEvent/partner/" + id;
            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(url).Result;
                if(!string.IsNullOrEmpty(response))
                {
                    var createEventForm = new JavaScriptSerializer().Deserialize<List<AddEvent>>(response);
                    dgvEvent.DataSource = createEventForm;
                }
                else
                {
                    dgvEvent.DataSource=null;
                }
            }
        }

        public CreateEventForm()
        {
            InitializeComponent();
        }
         

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnPreviousNewEvent_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();

        }

        private void btnEventCreate_Click(object sender, EventArgs e)
        {
            {
                string url = "https://localhost:7267/api/AddEvent?partnerId="+id;
                HttpClient httpClient = new HttpClient();
                AddEvent addEvent = new AddEvent();
                //addEvent.Id = id;
                addEvent.Name = txtEventName.Text;
                addEvent.Description = txtEventDescription.Text;
                addEvent.Location = txtEventVenue.Text;
                addEvent.Date = DateTime.Now;

                string data = (new JavaScriptSerializer()).Serialize(addEvent);
                var connect = new StringContent(data, Encoding.UTF8, "application/json");
                var res = httpClient.PostAsync(url, connect).Result;
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Event Added Succussfully");
                    LoadData();
                }
                else
                    MessageBox.Show("Faild to Add Event");
            }
        }

   

        private void LoadData()
        {
            string url = "https://localhost:7267/api/AddEvent/partner/" + id;
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);
            dgvEvent.DataSource = null;
            dgvEvent.DataSource = (new JavaScriptSerializer()).
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

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/AddEvent/" + id;
            HttpClient httpClient = new HttpClient();
            AddEvent addEvent = new AddEvent();
            addEvent.Id = id;
            addEvent.Name = txtEventName.Text;
            addEvent.Description = txtEventDescription.Text;
            addEvent.Location = txtEventVenue.Text;
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

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7267/api/AddEvent/" + id;
            HttpClient httpClient = new HttpClient();
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Delete Event",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var res = httpClient.DeleteAsync(url).Result;
                if (res.IsSuccessStatusCode)
                {
                    LoadData();
                    txtEventID.Clear();
                    txtEventName.Clear();
                    txtEventDescription.Clear(); 
                    txtEventVenue.Clear();
                    txtEventDate.Clear();
                }
                

            }
        }

 

        private void dgvEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                txtEventID.Text = dgvEvent.Rows[row].Cells[1].Value.ToString();
                txtEventName.Text = dgvEvent.Rows[row].Cells[2].Value.ToString();
                txtEventDescription.Text = dgvEvent.Rows[row].Cells[3].Value.ToString();
                txtEventVenue.Text = dgvEvent.Rows[row].Cells[4].Value.ToString();
                txtEventDate.Text = dgvEvent.Rows[row].Cells[5].Value.ToString();
                txtEventPartnerID.Text = dgvEvent.Rows[row].Cells[6].Value.ToString();
                id = Convert.ToInt32(dgvEvent.Rows[row].Cells[1].Value.ToString());
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEventDelete_Click_1(object sender, EventArgs e)
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
                    txtEventID.Clear();
                    txtEventName.Clear();
                    txtEventDescription.Clear();
                    txtEventDate.Clear();
                    txtEventVenue.Clear();

                }
            }
        }
    }
}
