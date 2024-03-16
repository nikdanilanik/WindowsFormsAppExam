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
    public partial class UpdateRepairRequest : Form
    {
        RepairRequest repairRequest = new RepairRequest();
        ClientRepository clientRepository = new ClientRepository();
        RepairRequestRepository repairRepository = new RepairRequestRepository();
        public UpdateRepairRequest()
        {
            InitializeComponent();
            comboBoxStatus.Items.Add("Подано");
            comboBoxStatus.Items.Add("Начато");
            comboBoxStatus.Items.Add("Ожидание деталей");
            comboBoxStatus.Items.Add("В роботе");
            comboBoxStatus.Items.Add("Ожидание клиента");
            comboBoxStatus.Items.Add("Завершено");
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFindData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text))
            {
                repairRequest = repairRepository.getClientById(Convert.ToInt32(textBoxFindId.Text));
                
                if (repairRequest != null)
                {
                    if (repairRequest.dateOfCompletion.ToString() == "01.01.0001 0:00:00")
                    {
                        textBoxDateOfCreate.Text = repairRequest.dateOfCreate.ToString();
                        textBoxDateOfCreate.ReadOnly = false;
                        textBoxItemName.Text = repairRequest.itemName;
                        textBoxItemName.ReadOnly = false;
                        textBoxType.Text = repairRequest.typeEquipment;
                        textBoxType.ReadOnly = false;
                        textBoxDescription.Text = repairRequest.problemDescription;
                        textBoxDescription.ReadOnly = false;
                        textBoxClientId.Text = repairRequest.client.id.ToString();
                        textBoxClientId.ReadOnly = false;
                        textBoxUserId.Text = repairRequest.responsibleUser.id.ToString();
                        textBoxUserId.ReadOnly = false;
                        comboBoxStatus.SelectedItem = repairRequest.requestStatus;
                        comboBoxStatus.Enabled = true;
                        buttonNext.Enabled = true;
                    } else
                    {
                        textBoxDateOfCreate.Text = repairRequest.dateOfCreate.ToString();
                        textBoxDateOfCreate.ReadOnly = true;
                        textBoxItemName.Text = repairRequest.itemName;
                        textBoxItemName.ReadOnly = true;
                        textBoxType.Text = repairRequest.typeEquipment;
                        textBoxType.ReadOnly = true;
                        textBoxDescription.Text = repairRequest.problemDescription;
                        textBoxDescription.ReadOnly = true;
                        textBoxClientId.Text = repairRequest.client.id.ToString();
                        textBoxClientId.ReadOnly = true;
                        textBoxUserId.Text = repairRequest.responsibleUser.id.ToString();
                        textBoxUserId.ReadOnly = true;
                        comboBoxStatus.SelectedItem = repairRequest.requestStatus;
                        comboBoxStatus.Enabled = false;
                        buttonNext.Enabled = false;
                    }
                }
                else
                {
                    textBoxDateOfCreate.Text = "";
                    textBoxItemName.Text = "";
                    textBoxType.Text = "";
                    textBoxDescription.Text = "";
                    textBoxClientId.Text = "";
                    textBoxUserId.Text = "";
                    comboBoxStatus.SelectedItem = "";
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxDateOfCreate.Text) & !string.IsNullOrWhiteSpace(textBoxDateOfCreate.Text)) &
                (!string.IsNullOrEmpty(textBoxItemName.Text) & !string.IsNullOrWhiteSpace(textBoxItemName.Text)) &
                (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text)) &
                (!string.IsNullOrEmpty(textBoxType.Text) & !string.IsNullOrWhiteSpace(textBoxType.Text)) &
                (!string.IsNullOrEmpty(textBoxDescription.Text) & !string.IsNullOrWhiteSpace(textBoxDescription.Text)) &
                (!string.IsNullOrEmpty(textBoxUserId.Text) & !string.IsNullOrEmpty(textBoxUserId.Text)) &
                (!string.IsNullOrEmpty(textBoxClientId.Text) & !string.IsNullOrWhiteSpace(textBoxClientId.Text)))
            {
                if (clientRepository.getClientById(Convert.ToInt32(textBoxClientId.Text)) != null)
                {
                    repairRequest.dateOfCreate = Convert.ToDateTime(textBoxDateOfCreate.Text);
                    repairRequest.itemName = textBoxItemName.Text;
                    repairRequest.typeEquipment = textBoxType.Text;
                    repairRequest.problemDescription = textBoxDescription.Text;
                    repairRequest.client.id = Convert.ToInt32(textBoxClientId.Text);
                    repairRequest.responsibleUser.id = Convert.ToInt32(textBoxUserId.Text);
                    repairRequest.requestStatus = comboBoxStatus.SelectedItem.ToString();
                    if (repairRequest.requestStatus == "Завершено")
                    {
                        repairRequest.dateOfCompletion = DateTime.Now;
                    }
                    repairRepository.updateRequestById(repairRequest);
                }
            }
        }

        private void textBoxFindId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFindId_TextChanged(object sender, EventArgs e)
        {
            textBoxDateOfCreate.Text = "";
            textBoxDateOfCreate.ReadOnly = true;
            textBoxItemName.Text = "";
            textBoxItemName.ReadOnly = true;
            textBoxType.Text = "";
            textBoxType.ReadOnly = true;
            textBoxDescription.Text = "";
            textBoxDescription.ReadOnly = true;
            textBoxClientId.Text = "";
            textBoxClientId.ReadOnly = true;
            textBoxUserId.Text = "";
            textBoxUserId.ReadOnly = true;
            comboBoxStatus.SelectedItem = "";
            comboBoxStatus.Enabled = false;
        }
    }
}
