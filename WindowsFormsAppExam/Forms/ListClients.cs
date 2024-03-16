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
using WindowsFormsAppExam.models;

namespace WindowsFormsAppExam.Forms
{
    public partial class ListClients : Form
    {
        ClientRepository clientRepository = new ClientRepository();
        List<Client> clients = new List<Client>();
        public ListClients()
        {
            InitializeComponent();
            clients = clientRepository.getAllClients();
            dataGridView1.DataSource = clients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            clients = clientRepository.getClientByPhoneNumberOrName(textBoxFind.Text);
            dataGridView1.DataSource = clients;
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
