using TaskManagementMVC.Models;

namespace TaskManagementMVC.Services
{
    public interface IAuthenticate
    {
        public void Register(UserModel user);
    }
}
