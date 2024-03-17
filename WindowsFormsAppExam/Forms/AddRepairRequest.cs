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
    public partial class AddRepairRequest : Form
    {
        public AddRepairRequest()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            RepairRequest repairRequest = new RepairRequest(
                DateTime.Now,
                DateTime.MinValue,
                textBoxItemName.Text,
                textBoxTypeEquipment.Text,
                textBoxProblemDesc.Text,
                new Client(Convert.ToInt32(textBoxClientId.Text), null, null, null),
                ConstData.CURRENT_USER,
                "Подано");
            RepairRequestRepository requestRepository = new RepairRequestRepository();
            requestRepository.addRequest(repairRequest);
        }

        private void textBoxClientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) & number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
