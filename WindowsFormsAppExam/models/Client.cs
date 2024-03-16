using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExam.models
{
    public class Client
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public Client() { }

        public Client(int id, string name, string phoneNumber, string email)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Client(string name, string phoneNumber, string email)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
