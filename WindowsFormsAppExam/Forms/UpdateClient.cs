using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsAppExam.dbRepositories;
using WindowsFormsAppExam.models;

namespace WindowsFormsAppExam.Forms
{
    public partial class UpdateClient : Form
    {
        Client client = new Client();
        ClientRepository clientRepository = new ClientRepository();
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxFIO.Text) & !string.IsNullOrWhiteSpace(textBoxFIO.Text)) &
                (!string.IsNullOrEmpty(textBoxEmail.Text) & !string.IsNullOrWhiteSpace(textBoxEmail.Text)) &
                (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text)) &
                (!string.IsNullOrEmpty(textBoxNumberPhone.Text) & !string.IsNullOrWhiteSpace(textBoxNumberPhone.Text))) 
            {
                client.name = textBoxFIO.Text;
                client.phoneNumber = textBoxNumberPhone.Text;
                client.email = textBoxEmail.Text;
                clientRepository.updateClientById(client);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text))
            {
                client = clientRepository.getClientById(Convert.ToInt32(textBoxFindId.Text));
                if (client != null)
                {
                    textBoxFIO.Text = client.name;
                    textBoxFIO.ReadOnly = false;
                    textBoxNumberPhone.Text = client.phoneNumber;
                    textBoxNumberPhone.ReadOnly = false;
                    textBoxEmail.Text = client.email;
                    textBoxEmail.ReadOnly = false;
                }
                else
                {
                    textBoxFIO.Text = "";
                    textBoxNumberPhone.Text = "";
                    textBoxEmail.Text = "";
                }
            }
        }

        private void textBoxFindId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxFindId_TextChanged(object sender, EventArgs e)
        {
            textBoxFIO.Text = "";
            textBoxFIO.ReadOnly = true;
            textBoxNumberPhone.Text = "";
            textBoxNumberPhone.ReadOnly = true;
            textBoxEmail.Text = "";
            textBoxEmail.ReadOnly = true;
        }

        private void textBoxFindId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFindId_TextChanged_1(object sender, EventArgs e)
        {
            textBoxFIO.Text = "";
            textBoxFIO.ReadOnly = true;
            textBoxNumberPhone.Text = "";
            textBoxNumberPhone.ReadOnly = true;
            textBoxEmail.Text = "";
            textBoxEmail.ReadOnly = true;
        }
    }
}
