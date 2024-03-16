using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExam.dbRepositories
{
    public class ConnectionDB
    {
        public void createDefaultRepos()
        {
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS client (id SERIAL NOT NULL, name VARCHAR(50) NOT NULL, phone_number VARCHAR(12) NOT NULL, email VARCHAR(30), PRIMARY KEY(id));" +
                    "CREATE TABLE IF NOT EXISTS repair_request (id SERIAL NOT NULL, date_of_create DATE DEFAULT CURRENT_DATE, date_of_completion DATE DEFAULT NULL, item_name VARCHAR(80) NOT NULL, typeEquipment VARCHAR(50) NOT NULL, problemDescription VARCHAR(250) NOT NULL, clientId INT NOT NULL, userId INT NOT NULL, request_status VARCHAR(30), PRIMARY KEY(id), CONSTRAINT client FOREIGN KEY (clientId) REFERENCES client (id) ON DELETE NO ACTION ON UPDATE NO ACTION, CONSTRAINT users FOREIGN KEY (userId) REFERENCES users (id) ON DELETE NO ACTION ON UPDATE NO ACTION);" +
                    "CREATE TABLE IF NOT EXISTS users (id SERIAL NOT NULL, name VARCHAR(50) NOT NULL, login VARCHAR(50) NOT NULL, password VARCHAR(50) NOT NULL, access VARCHAR(50) NOT NULL, PRIMARY KEY(id));", con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public void deleteDefaultRepos()
        {
            using (var con = new NpgsqlConnection (ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("DROP TABLE IF EXISTS client, repair_request, users", con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
