using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppExam.models;

namespace WindowsFormsAppExam.dbRepositories
{
    public class ClientRepository
    {
        public void addClient(Client client)
        {
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("INSERT INTO client (name, phone_number, email) VALUES (@name, @phone_number, @email)", con))
                {
                    command.Parameters.AddWithValue("name", client.name);
                    command.Parameters.AddWithValue("phone_number", client.phoneNumber);
                    command.Parameters.AddWithValue("email", client.email);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Клиент добавлен");
                con.Close();
            }
        }
        public List<Client> getAllClients()
        {
            List<Client> clients = new List<Client>();
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM client ORDER BY id", con))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                phoneNumber = reader.GetString(2),
                                email = reader.GetString(3)
                            });
                        }
                        con.Close();
                        return clients;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public Client getClientById(int id)
        {
            Client client = new Client();
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM client WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        client.id = reader.GetInt32(0);
                        client.name = reader.GetString(1);
                        client.phoneNumber = reader.GetString(2);
                        client.email = reader.GetString(3);

                        con.Close();
                        return client;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public List<Client> getClientByPhoneNumberOrName(string findString)
        {
            List<Client> clients = new List<Client>();
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM client WHERE phone_number LIKE '%' || @findString || '%' " +
                    "OR name LIKE '%' || @findString || '%'", con))
                {
                    command.Parameters.AddWithValue("findString", findString);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                phoneNumber = reader.GetString(2),
                                email = reader.GetString(3)
                            });
                        }
                        return clients;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public void removeClientById(int id)
        {
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("DELETE FROM client WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Клиент удалён");
            }
        }
        public void updateClientById(Client client)
        {
            using (var con = new NpgsqlConnection(ConstDataDB.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("UPDATE client SET name = @name, phone_number = @phone_number, email = @email WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", client.id);
                    command.Parameters.AddWithValue("name", client.name);
                    command.Parameters.AddWithValue("phone_number", client.phoneNumber);
                    command.Parameters.AddWithValue("email", client.email);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Клиент обновлен");
            }
        }
    }
}
