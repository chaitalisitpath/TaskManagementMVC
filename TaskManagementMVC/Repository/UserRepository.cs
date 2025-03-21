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

        public Task<long> Register(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
