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

namespace WindowsFormsAppExam.Forms
{
    public partial class RemoveUser : Form
    {
        UserRepository userRepository = new UserRepository();
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userRepository.getUserById(Convert.ToInt32(textBox1.Text)) != null) {
                userRepository.removeUserById(Convert.ToInt32(textBox1.Text));
            }
        }
    }
}
