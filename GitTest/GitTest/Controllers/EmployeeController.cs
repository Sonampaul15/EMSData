using Microsoft.AspNetCore.Mvc;

namespace GitTest.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
