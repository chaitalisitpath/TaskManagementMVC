using TaskManagementMVC.Models;

namespace TaskManagementMVC.Services
{
    public interface IAuthenticate
    {
     
        public Task<UserModel> Authenticate(string username, string password);
    }
}
