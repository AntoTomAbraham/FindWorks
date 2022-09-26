using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using studentFreelance.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace studentFreelance.Controllers
{
    public class GigController : Controller
    {
        private readonly GigDbcontext gigdb;

        public GigController(GigDbcontext gigdb)
        {
            this.gigdb = gigdb;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var gigs = await gigdb.gig.ToListAsync();
            return View(gigs);
        }
        public async Task<IActionResult> myIndex()
        {
            var gigs = await gigdb.gig.ToListAsync();
            return View(gigs);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddgigViewmodel req)
        {
            var gig = new Gig()
            {
                amount = req.amount,
                desc = req.desc,
                email = @User.Identity?.Name,
                title = req.title
            };
            await gigdb.gig.AddAsync(gig);
            await gigdb.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
