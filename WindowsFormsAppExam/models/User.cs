using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExam.models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string access {  get; set; }
        public User() { }

        public User(int id, string name, string login, string password, string access)
        {
            this.id = id;
            this.name = name;
            this.login = login;
            this.password = password;
            this.access = access;
        }

        public User(string name, string login, string password, string access)
        {
            this.name = name;
            this.login = login;
            this.password = password;
            this.access = access;
        }
    }
}
