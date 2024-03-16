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
    public partial class ListUsers : Form
    {
        UserRepository userRepository = new UserRepository();
        List<User> users = new List<User>();
        public ListUsers()
        {
            InitializeComponent();
            users = userRepository.getAllUsers();
            dataGridView1.DataSource = users;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            users = userRepository.getUsersByNameOrId(textBoxFind.Text);
            dataGridView1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveUser removeUser = new RemoveUser();
            removeUser.Show();
        }
    }
}
