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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppExam.Forms
{
    public partial class TrackRequest : Form
    {
        RepairRequestRepository repairReques = new RepairRequestRepository();
        public TrackRequest()
        {
            InitializeComponent();
            if (ConstDataDB.TRACK_REQUEST != null)
            {
                ConstDataDB.TRACK_REQUEST = repairReques.getClientById(ConstDataDB.TRACK_REQUEST.id);
                textBoxRequestId.Text = Convert.ToString(ConstDataDB.TRACK_REQUEST.id);
                textBoxStatusRequest.Text = ConstDataDB.TRACK_REQUEST.requestStatus;
            }
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRequestId.Text))
            {
                ConstDataDB.TRACK_REQUEST = repairReques.getClientById(Convert.ToInt32(textBoxRequestId.Text));
                textBoxStatusRequest.Text = ConstDataDB.TRACK_REQUEST.requestStatus;
            }
        }

        private void textBoxRequestId_Leave(object sender, EventArgs e)
        {
            if (textBoxRequestId.Text == "") { textBoxRequestId.Text = "id"; }
        }

        private void textBoxRequestId_Enter(object sender, EventArgs e)
        {
            if (textBoxRequestId.Text == "id") { textBoxRequestId.Text = ""; }
        }

        private void textBoxStatusRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { }
            else if (e.KeyChar == (char)Keys.Back) { textBoxRequestId.Text = ""; }
            else { e.Handled = true; }
        }
    }
}
