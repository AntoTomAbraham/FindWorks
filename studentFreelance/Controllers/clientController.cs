using Microsoft.AspNetCore.Mvc;

namespace studentFreelance.Controllers
{
    public class clientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
