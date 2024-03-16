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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            comboBoxAccess.Items.Add("user");
            comboBoxAccess.Items.Add("admin");
            comboBoxAccess.SelectedIndex = 0;
            comboBoxAccess.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) & !string.IsNullOrWhiteSpace(textBoxName.Text)
                & !string.IsNullOrEmpty(textBoxLogin.Text) & !string.IsNullOrWhiteSpace(textBoxLogin.Text)
                & !string.IsNullOrEmpty(textBoxPassword.Text) & !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                User user = new User(textBoxName.Text, textBoxLogin.Text, textBoxPassword.Text, comboBoxAccess.SelectedItem.ToString());
                UserRepository userRepository = new UserRepository();
                userRepository.addUser(user);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
