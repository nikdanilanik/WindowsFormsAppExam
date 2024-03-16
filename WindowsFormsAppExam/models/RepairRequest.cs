using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExam.models
{
    public class RepairRequest
    {
        public int id { get; set; }
        public DateTime dateOfCreate { get; set; }
        public DateTime dateOfCompletion { get; set; }
        public string itemName { get; set; }
        public string typeEquipment { get; set; }
        public string problemDescription { get; set; }
        public Client client { get; set; }
        public User responsibleUser { get; set; }
        public string requestStatus { get; set; }

        public RepairRequest()
        {
            this.client = new Client();
        }

        public RepairRequest(int id, DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, Client client, User responsibleUser, string requestStatus)
        {
            this.id = id;
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.client = client;
            this.responsibleUser = responsibleUser;
            this.requestStatus = requestStatus;
        }

        public RepairRequest(DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, Client client, User responsibleUser, string requestStatus)
        {
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.client = client;
            this.responsibleUser = responsibleUser;
            this.requestStatus = requestStatus;
        }

        public RepairRequest(int id, DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, User responsibleUser, string requestStatus)
        {
            this.id = id;
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.responsibleUser = responsibleUser;
            this.requestStatus = requestStatus;
        }

        public RepairRequest(int id, DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, Client client, string requestStatus)
        {
            this.id = id;
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.client = client;
            this.requestStatus = requestStatus;
        }

        public RepairRequest(DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, User responsibleUser, string requestStatus)
        {
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.responsibleUser = responsibleUser;
            this.requestStatus = requestStatus;
        }

        public RepairRequest(DateTime dateOfCreate, DateTime dateOfCompletion, string itemName, string typeEquipment, string problemDescription, Client client, string requestStatus)
        {
            this.dateOfCreate = dateOfCreate;
            this.dateOfCompletion = dateOfCompletion;
            this.itemName = itemName;
            this.typeEquipment = typeEquipment;
            this.problemDescription = problemDescription;
            this.client = client;
            this.requestStatus = requestStatus;
        }
    }
}
