using TaskManagementMVC.Models;
using TaskManagementMVC.Repository;

namespace TaskManagementMVC.Services
{
    public class Authenticate : IAuthenticate
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Authenticate(IUserRepository userRepository, IHttpContextAccessor HttpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = HttpContextAccessor;
        }
         async Task<UserModel?> IAuthenticate.Authenticate(string username, string password)
        {
            var user = await _userRepository.Authenticate(username, password);
            if (user != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("username", user.Username);
            }
            return user;
        }
        public void Logout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("username");
        }
    }
}
