using Microsoft.AspNetCore.Mvc;

namespace studentFreelance.Controllers
{
    public class freelanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
