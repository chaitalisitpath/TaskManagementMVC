using Microsoft.AspNetCore.Mvc;

namespace TaskManagementMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
