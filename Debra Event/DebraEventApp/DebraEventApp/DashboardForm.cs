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
    public partial class DashboardForm : Form
    {
        public int PID;
        public DashboardForm(int id)
        {
            InitializeComponent();
            PID = id;
        }
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm createEventForm = new CreateEventForm(PID);
            createEventForm.Show();
            this.Hide();

        }

        private void btnSetTickets_Click(object sender, EventArgs e)
        {
            SetTicketForm setTicketForm = new SetTicketForm();
            setTicketForm.Show();
            this.Hide();
        }

        private void btnMainMenuDashboard_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoutDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
