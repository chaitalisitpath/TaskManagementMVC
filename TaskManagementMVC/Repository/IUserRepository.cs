using TaskManagementMVC.Models;

namespace TaskManagementMVC.Repository
{
    public interface IUserRepository
    {
        Task<long> Register(UserModel user);

      
    }
}
