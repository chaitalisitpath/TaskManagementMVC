using Dapper;
using System.Data;
using TaskManagementMVC.Models;

namespace TaskManagementMVC.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public UserRepository(IDbConnection dbConnection) {
            _dbConnection = dbConnection;
        }

        public async Task<int> Register(UserModel user)
        {
            string query = "INSERT INTO Users (username, password, gender) OUTPUT INSERTED.Id VALUES (@username, @password, @gender)";
            var response = await _dbConnection.ExecuteScalarAsync<int>(query, user);
            return response;
        }
        public async Task<UserModel?> Authenticate(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE username = @username AND password = @password";
            return await _dbConnection.QueryFirstOrDefaultAsync<UserModel>(query, new { username, password });
           
        }

    }
}
