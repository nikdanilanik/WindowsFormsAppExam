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
    public partial class UpdateUser : Form
    {
        User user = new User();
        UserRepository userRepository = new UserRepository();
        public UpdateUser()
        {
            InitializeComponent();
            comboBoxAccess.Items.Add("user");
            comboBoxAccess.Items.Add("admin");
            comboBoxAccess.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text))
            {
                user = userRepository.getUserById(Convert.ToInt32(textBoxFindId.Text));
                if (user != null)
                {
                    textBoxName.Text = user.name;
                    textBoxName.ReadOnly = false;
                    textBoxLogin.Text = user.login;
                    textBoxLogin.ReadOnly = false;
                    textBoxPassword.Text = user.password;
                    textBoxPassword.ReadOnly = false;
                    comboBoxAccess.SelectedItem = user.access;
                    comboBoxAccess.Enabled = true;
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    comboBoxAccess.SelectedItem = "";
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
            textBoxName.Text = "";
            textBoxName.ReadOnly = true;
            textBoxLogin.Text = "";
            textBoxLogin.ReadOnly = true;
            textBoxPassword.Text = "";
            textBoxPassword.ReadOnly = true;
            comboBoxAccess.SelectedItem = null;
            comboBoxAccess.Enabled = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxName.Text) & !string.IsNullOrWhiteSpace(textBoxName.Text)) &
                (!string.IsNullOrEmpty(textBoxLogin.Text) & !string.IsNullOrWhiteSpace(textBoxLogin.Text)) &
                (!string.IsNullOrEmpty(textBoxFindId.Text) & !string.IsNullOrWhiteSpace(textBoxFindId.Text)) &
                (!string.IsNullOrEmpty(textBoxPassword.Text) & !string.IsNullOrWhiteSpace(textBoxPassword.Text)))
            {
                if (userRepository.getUserById(Convert.ToInt32(textBoxFindId.Text)) != null)
                {
                    user.name = textBoxName.Text;
                    user.login = textBoxLogin.Text;
                    user.password = textBoxPassword.Text;
                    user.access = comboBoxAccess.SelectedItem.ToString();
                    userRepository.updateUser(user);
                }
            }
        }

        private void comboBoxAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
