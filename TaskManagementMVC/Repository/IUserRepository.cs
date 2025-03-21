using TaskManagementMVC.Models;

namespace TaskManagementMVC.Repository
{
    public interface IUserRepository
    {
        Task<int> Register(UserModel user);
        Task<UserModel> Authenticate(string username, string password);

    }
}
