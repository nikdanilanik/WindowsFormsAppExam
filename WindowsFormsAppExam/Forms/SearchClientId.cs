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
    public partial class SearchClientId : Form
    {
        public SearchClientId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientRepository clientRepository = new ClientRepository();
            Client client = clientRepository.getClientByPhoneNumberOrName(this.textBox1.Text)[0];
            MessageBox.Show("айди клинта: " + client.id);
            this.Close();
        }
    }
}
