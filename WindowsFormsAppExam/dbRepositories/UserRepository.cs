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
    public class UserRepository
    {
        public void addUser(User user)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("INSERT INTO users (name, login, password, access) VALUES (@name ,@login, @password, @access)", con))
                {
                    command.Parameters.AddWithValue("name", user.name);
                    command.Parameters.AddWithValue("login", user.login);
                    command.Parameters.AddWithValue("Password", user.password);
                    command.Parameters.AddWithValue("access", user.access);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Пользователь добавлен");
            }
        }
        public void removeUserById(int id)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("DELETE FROM users WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Пользователь удалён");
            }
        }
        public List<User> getUsersByNameOrId(string findString)
        {
            List<User> users = new List<User>();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM users WHERE name LIKE '%' || @findString || '%' " +
                    "OR id = @findInt", con))
                {
                    if (int.TryParse(findString, out int intValue))
                    {
                        command.Parameters.AddWithValue("findString", DBNull.Value);
                        command.Parameters.AddWithValue("findInt", intValue);
                    } else
                    {
                        command.Parameters.AddWithValue("findString", findString);
                        command.Parameters.AddWithValue("findInt", DBNull.Value);
                    }
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                login = reader.GetString(2),
                                password = reader.GetString(3),
                                access = reader.GetString(4),
                            });
                        }
                        return users;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM users", con))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                login = reader.GetString(2),
                                password = reader.GetString(3),
                                access = reader.GetString(4)
                            });
                        }
                        con.Close(); return users;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public User getUserById(int id)
        {
            User user = new User();
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM users WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", id);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user.id = reader.GetInt32(0);
                        user.name = reader.GetString(1);
                        user.login = reader.GetString(2);
                        user.password = reader.GetString(3);
                        user.access = reader.GetString(4);

                        con.Close();
                        return user;
                    }
                    else { con.Close(); return null; }
                }
            }
        }
        public void updateUser(User user)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("UPDATE users SET name = @name, login = @login, password = @password, access = @access WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("id", user.id);
                    command.Parameters.AddWithValue("name", user.name);
                    command.Parameters.AddWithValue("login", user.login);
                    command.Parameters.AddWithValue("password", user.password);
                    command.Parameters.AddWithValue("access", user.access);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь обновлён");
                }
                con.Close();
            }
        }
        public User getUserByPasswordAndLogin(string login, string password)
        {
            using (var con = new NpgsqlConnection(ConstData.CONNSTRING))
            {
                con.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM users WHERE login = @login AND password = @password", con))
                {
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("Password", password);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        User user = new User
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            login = reader.GetString(2),
                            password = reader.GetString(3),
                            access = reader.GetString(4)
                        };
                        con.Close();
                        return user;
                    } else
                    {
                        con.Close();
                        return null;
                    }
                }
            }
        }
    }
}
