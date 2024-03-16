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
    public partial class Auth : Form
    {
        UserRepository userRepository = new UserRepository();
        User user = new User();
        public Auth()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //user = userRepository.getUserByPasswordAndLogin(textBoxLogin.Text, textBoxPassword.Text);
            //if (user != null)
            //{
            //    ConstDataDB.CURRENTUSER = user;
            //    this.Hide();
            //    Form1 form = new Form1();
            //    form.FormClosed += (s, args) => this.Close();
            //    form.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Проверьте логин и пароль");
            //}
            AuthwithoutAuthForAdmin();
        }
        private void AuthwithoutAuthForAdmin()
        {
            user = new User(3, "Иванов", "admin1", "qwe", "admin");
            ConstDataDB.CURRENT_USER = user;
            this.Hide();
            Form1 form = new Form1();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
