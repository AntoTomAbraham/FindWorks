using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;

namespace studentFreelance.Controllers
{
    public class clientController : Controller

    {
        private readonly ClientDBcontext clientdb;
        public clientController(ClientDBcontext client)
        {
            this.clientdb = client;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Client req)
        {
            var clie = new Client()
            {
                name=req.name,
                email= @User.Identity?.Name,
                phno=req.phno
            };
            await clientdb.client.AddAsync(clie);
            await clientdb.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
