using Microsoft.AspNetCore.Mvc;

namespace CompanyHRandLeaveManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
