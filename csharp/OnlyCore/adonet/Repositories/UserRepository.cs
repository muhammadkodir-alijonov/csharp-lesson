using adonet.Constans;
using adonet.Interface.Repositories;
using adonet.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet.Repositories571632
{
    public class UserRepository : IUserRepository
    {
        private readonly NpgsqlConnection _connection = new NpgsqlConnection(DbConstants.CONNECTION_STRING);
        public async Task<int> CreateAsync(User user)
        {
            try
            {
                await _connection.OpenAsync();
                string query = "INSERT INTO public.users(\r\n\tfull_name, email, phone_number, adress)" +
                $" VALUES(@fullname, @email', @phone, @adress);";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection)
                {
                    Parameters =
                    {
                        new("fullname", user.FullName),
                        new("email", user.Email),
                        new("phone", user.PhoneNUmber),
                        new("adress", user.Adress),

                    }
                };
                int result = npgsqlCommand.ExecuteNonQuery();
                return result;
            }
            catch 
            {
                 return 0;
            }

            finally
            {
                await _connection.CloseAsync();
            }
            
        }

        public async Task<int> DeleteAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"DELETE from users where id ={id}";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection);
                int result = await npgsqlCommand.ExecuteNonQueryAsync();
                return result;
            }
            catch
            {
                return 0;
            }

            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<User?> FindEmailAsync(string email)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"SELECT * FROM users where email = '{email}';";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection);
                var reader = await npgsqlCommand.ExecuteReaderAsync();
                var result = await reader.ReadAsync();
                if (result)
                {
                    return new User()
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNUmber = reader.GetString(3),
                        Adress = reader.GetString(4)
                    };
                }
                else return null;

            }
            catch
            {
                return null;
            }

            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync(int skip, int take)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"SELECT * FROM users offset {skip} limit {take};";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection);
                var reader = await npgsqlCommand.ExecuteReaderAsync();
                List<User> users = new List<User>();
                while (await reader.ReadAsync())
                {
                    User user = new User()
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNUmber = reader.GetString(3),
                        Adress = reader.GetString(4)
                    };
                    users.Add(user);
                } 
                return users;
            }
            catch
            {
                return new List<User>();
            }

            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<User?> GetAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"SELECT * FROM users where id = {id}";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection);
                var reader = await npgsqlCommand.ExecuteReaderAsync();
                var result =  await reader.ReadAsync();
                if(result)
                {
                    return new User()
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNUmber = reader.GetString(3),
                        Adress = reader.GetString(4)
                    };
                }
                else return null;
                    
            }
            catch
            {
                return null;
            }

            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<int> UpdateAsync(long id, User user)
        {
            try
            {
                await _connection.OpenAsync();
                string query = "update users "+
                                $"set full_name = '{user.FullName}', email = '{user.Email}'," +
                                $"phone_number = '{user.PhoneNUmber}', adress = '{user.Adress}'"+
                                $"where id = {id}";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, _connection);
                int result = await npgsqlCommand.ExecuteNonQueryAsync();
                return result;
            }
            catch
            {
                return 0;
            }

            finally
            {
                await _connection.CloseAsync();
            }
        }
    }
}
