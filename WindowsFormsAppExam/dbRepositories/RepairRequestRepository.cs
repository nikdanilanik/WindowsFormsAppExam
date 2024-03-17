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
    public class RepairRequestRepository
    {
        public void addRequest(RepairRequest repairRequest)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("INSERT INTO repair_request (date_of_create, date_of_completion, item_name, typeequipment, problemdescription, clientid, userid, request_status) " +
                    "VALUES (@date_of_create, @date_of_completion, @item_name, @typeequipment, @problemdescription, @clientid, @userid, @request_status)", con))
                {
                    command.Parameters.AddWithValue("date_of_create", repairRequest.dateOfCreate);
                    command.Parameters.AddWithValue("date_of_completion", repairRequest.dateOfCompletion);
                    command.Parameters.AddWithValue("item_name", repairRequest.itemName);
                    command.Parameters.AddWithValue("typeequipment", repairRequest.typeEquipment);
                    command.Parameters.AddWithValue("problemdescription", repairRequest.problemDescription);
                    command.Parameters.AddWithValue("clientid", repairRequest.client.id);
                    command.Parameters.AddWithValue("userid", repairRequest.responsibleUser.id);
                    command.Parameters.AddWithValue("request_status", repairRequest.requestStatus);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Заявка создана");
        }
        public List<RepairRequest> getAllRequests()
        {
            ClientRepository clientRepository = new ClientRepository();
            UserRepository userRepository = new UserRepository();
            List<RepairRequest> repairRequests = new List<RepairRequest>();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM repair_request ORDER BY id", con))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            repairRequests.Add(new RepairRequest
                            {
                                id = reader.GetInt32(0),
                                dateOfCreate = reader.GetDateTime(1),
                                dateOfCompletion = reader.GetDateTime(2),
                                itemName = reader.GetString(3),
                                typeEquipment = reader.GetString(4),
                                problemDescription = reader.GetString(5),
                                client = clientRepository.getClientById(reader.GetInt32(6)),
                                responsibleUser = userRepository.getUserById(reader.GetInt32(7)),
                                requestStatus = reader.GetString(8),
                            });;
                        }
                        con.Close();
                        return repairRequests;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public RepairRequest getClientById(int id)
        {
            UserRepository userRepository = new UserRepository();
            ClientRepository clientRepository = new ClientRepository();
            RepairRequest repairRequest = new RepairRequest();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM repair_request WHERE id = @id ORDER BY id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        repairRequest.id = reader.GetInt32(0);
                        repairRequest.dateOfCreate = reader.GetDateTime(1);
                        repairRequest.dateOfCompletion = reader.GetDateTime(2);
                        repairRequest.itemName = reader.GetString(3);
                        repairRequest.typeEquipment = reader.GetString(4);
                        repairRequest.problemDescription = reader.GetString(5);
                        repairRequest.client = clientRepository.getClientById(reader.GetInt32(6));
                        repairRequest.responsibleUser = userRepository.getUserById(reader.GetInt32(7));
                        repairRequest.requestStatus = reader.GetString(8);

                        con.Close();
                        return repairRequest;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public List<RepairRequest> getRequestByItemNameOrClientId(string findString)
        {
            UserRepository userRepository = new UserRepository();
            ClientRepository clientRepository = new ClientRepository();
            List<RepairRequest> repairRequests = new List<RepairRequest>();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM repair_request WHERE item_name LIKE '%' || @findString || '%' " +
                    "OR CAST(clientid AS TEXT) LIKE '%' || @findString || '%'", con))
                {
                    command.Parameters.AddWithValue("findString", findString);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            repairRequests.Add(new RepairRequest
                            {
                                id = reader.GetInt32(0),
                                dateOfCreate = reader.GetDateTime(1),
                                dateOfCompletion = reader.GetDateTime(2),
                                itemName = reader.GetString(3),
                                typeEquipment = reader.GetString(4),
                                problemDescription = reader.GetString(5),
                                client = clientRepository.getClientById(reader.GetInt32(6)),
                                responsibleUser = userRepository.getUserById(reader.GetInt32(7)),
                                requestStatus = reader.GetString(8),
                            });
                        }
                        return repairRequests;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public void removeClientById(int id)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("DELETE FROM repair_request WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public void updateRequestById(RepairRequest repairRequest)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("UPDATE repair_request SET date_of_create = @date_of_create, date_of_completion = @date_of_completion, " +
                    "item_name = @item_name, typeequipment = @typeequipment, problemdescription = @problemdescription, " +
                    "clientid = @clientid, userid = @userid, request_status = @request_status WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", repairRequest.id);
                    command.Parameters.AddWithValue("date_of_create", repairRequest.dateOfCreate);
                    command.Parameters.AddWithValue("date_of_completion", repairRequest.dateOfCompletion);
                    command.Parameters.AddWithValue("item_name", repairRequest.itemName);
                    command.Parameters.AddWithValue("typeequipment", repairRequest.typeEquipment);
                    command.Parameters.AddWithValue("problemdescription", repairRequest.problemDescription);
                    command.Parameters.AddWithValue("client", repairRequest.client.id);
                    command.Parameters.AddWithValue("userid", repairRequest.responsibleUser.id);
                    command.Parameters.AddWithValue("request_status", repairRequest.requestStatus);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Заявка обновлена");
            }
        }
    }
}
