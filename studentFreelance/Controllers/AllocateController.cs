using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;

namespace studentFreelance.Controllers
{
    public class AllocateController : Controller
    {
        private readonly GigDbcontext allodb;
        public AllocateController(GigDbcontext allo)
        {
            this.allodb = allo;
        }
        public IActionResult Index(Guid prid,int amount,String email,int deadline)
        {
            ViewBag.projectID = prid;
            ViewBag.amount = amount;
            ViewBag.email = email;
            ViewBag.deadline = deadline;
            return View();
        }
        public async Task<IActionResult> viewmyAllocatedProject()
        {
            return View(await allodb.allo.ToListAsync());
        }

        public async Task<IActionResult> viewmyFreeAllo()
        {
            return View(await allodb.allo.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> completeWork(Guid allID)
        {
          
                var user = allodb.allo.Where(u => u.allId == allID).FirstOrDefault();
                user.status = "Completed";
                allodb.SaveChanges();
           
            return View();
        }

            [HttpPost]
        public async Task<IActionResult> allocate(Allocate req)
        {
            var allo = new Allocate()
            {
                amount = req.amount,
                FRemail = req.FRemail,
                deadline = req.deadline,
                prID = req.prID,
                status="false",
                dealDate=DateTime.Now,
                allId = Guid.NewGuid()
            };
            await allodb.allo.AddAsync(allo);
            await allodb.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
