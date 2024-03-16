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
    public partial class ListRepairRequest : Form
    {
        RepairRequestRepository repairRequestRepository = new RepairRequestRepository();
        List<RepairRequest> repairRequests = new List<RepairRequest>();
        public ListRepairRequest()
        {
            InitializeComponent();
            repairRequests = repairRequestRepository.getAllRequests();
            dataGridView1.DataSource = repairRequests;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            repairRequests = repairRequestRepository.getRequestByItemNameOrClientId(textBoxFind.Text);
            dataGridView1.DataSource = repairRequests;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "client")
            {
                var repairRequest = dataGridView1.Rows[e.RowIndex].DataBoundItem as RepairRequest;
                if (repairRequest != null && repairRequest.client != null)
                {
                    e.Value = repairRequest.client.id;
                }
            }
        }

        private void buttonFindById_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFindById.Text))
            {
                RepairRequest repairRequest = repairRequestRepository.getClientById(Convert.ToInt32(textBoxFindById.Text));
                repairRequests.Clear();
                repairRequests.Add(repairRequest);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repairRequests;
            }
        }

        private void textBoxFindById_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
