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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) & !string.IsNullOrWhiteSpace(textBoxName.Text)
                & !string.IsNullOrEmpty(textBoxPhoneNumber.Text) & !string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text)
                & !string.IsNullOrEmpty(textBoxEmail.Text) & !string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                Client client = new Client(textBoxName.Text, textBoxPhoneNumber.Text, textBoxEmail.Text);
                ClientRepository clientRepository = new ClientRepository();
                clientRepository.addClient(client);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
