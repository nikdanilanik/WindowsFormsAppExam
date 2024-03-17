using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppExam.dbRepositories;
using WindowsFormsAppExam.Forms;
using WindowsFormsAppExam.models;

namespace WindowsFormsAppExam
{
    public partial class Form1 : Form
    {
        ConnectionDB db = new ConnectionDB();
        public Form1()
        {
            InitializeComponent();
            if (ConstData.CURRENT_USER.access != "admin")
            {
                buttonListUsers.Visible = false;
                deleteDefaultRepos.Visible = false;
                createDefaultRepos.Visible = false;
            }
        }

        private void createDefaultRepos_Click(object sender, EventArgs e)
        {
            db.createDefaultRepos();
        }

        private void deleteDefaultRepos_Click(object sender, EventArgs e)
        {
            db.deleteDefaultRepos();
        }

        private void buttonRequestAdd_Click(object sender, EventArgs e)
        {
            AddRepairRequest addRepairRequest = new AddRepairRequest();
            addRepairRequest.Show();
        }

        private void buttonClientAdd_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void buttonFindClintByPhoneNumber_Click(object sender, EventArgs e)
        {
            SearchClientId searchClientId = new SearchClientId();
            searchClientId.ShowDialog();
        }

        private void buttonUpdateRequest_Click(object sender, EventArgs e)
        {
            UpdateRepairRequest updateRepairRequest = new UpdateRepairRequest();
            updateRepairRequest.Show();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient();
            updateClient.Show();
        }

        private void buttonListClients_Click(object sender, EventArgs e)
        {

            ListClients listClients = new ListClients();
            listClients.Show();
        }

        private void buttonListRequests_Click(object sender, EventArgs e)
        {
            ListRepairRequest listRepairRequest = new ListRepairRequest();
            listRepairRequest.Show();
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            ListUsers listUsers = new ListUsers();
            listUsers.Show();
        }

        private void buttonTrackRequest_Click(object sender, EventArgs e)
        {
            TrackRequest trackRequest = new TrackRequest();
            trackRequest.Show();
        }
    }
}
