
using Microsoft.AspNetCore.Mvc;
using TaskManagementMVC.Models;
using TaskManagementMVC.Repository;

namespace TaskManagementMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepository;
        public AccountController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }
       
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserModel user)
        {
            long response = await _userRepository.Register(user);
            if (response > 0)
            {   TempData["Message"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpGet]
        [Route("/login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
           var user = await _userRepository.Authenticate(request.Username, request.Password);
            if (user != null)
            {
                return RedirectToAction("Dashboard", "Account");
            }
            TempData["Message"] = "Invalid Username or Password";
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }   
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

    }
}
