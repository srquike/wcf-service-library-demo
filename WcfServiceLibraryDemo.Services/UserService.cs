using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading.Tasks;
using WcfServiceLibraryDemo.Services.Models;

namespace WcfServiceLibraryDemo.Services
{
    public class UserService : IUserService
    {
        private readonly string _connectionString;

        public UserService()
        {
            _connectionString = Properties.Settings.Default.DemoDb;
        }

        public async Task<bool> CreateAsync(UserModel user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }

                using (var command = new SqlCommand("spr_CreateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", user.Name);

                    var result = await command.ExecuteNonQueryAsync();

                    return result > 0;
                }
            }
        }

        public Task<bool> DeleteAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<UserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
