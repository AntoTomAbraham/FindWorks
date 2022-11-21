using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;
using System;

namespace studentFreelance.Controllers
{
    public class BidController : Controller
    {
        private readonly GigDbcontext biddb;
        private Guid ids;
        private readonly FreelancerDBcontext _context;
        public BidController(GigDbcontext biddB, FreelancerDBcontext context)
        {
            this.biddb = biddB;
            this._context = context;   
        }
        
        public async Task<IActionResult> Index(Guid id)
        {
            ids = id;
            ViewBag.MyString = id;
            ids = ViewBag.MyString;
            return View();
        }
        public async Task<IActionResult> done(Guid id)
        {
            
            return View();
        }
        public async Task<IActionResult> eror(Guid id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Bids req)
        {

            var project = await  _context.project.FindAsync(req.prID);
            if (req.amount > project.amount) {
                return RedirectToAction("eror");
            }
            var bid = new Bids()
                {
                    amount = req.amount,
                    desc = req.desc,
                    FRemail = @User.Identity?.Name,
                    deadline = req.deadline,
                    prID = req.prID,
                    bid = Guid.NewGuid()
                };
            await biddb.bids.AddAsync(bid);
            await biddb.SaveChangesAsync();
            return RedirectToAction("done");
        }

        public async Task<IActionResult> viewMybids(Guid id)
        {
            ViewBag.MyString = id;
            var bidd = await biddb.bids.ToListAsync();
            return View(bidd);
        }

        [HttpPost]
        public async Task<IActionResult> AddAlocation(Allocate req)
        {
            var allow = new Allocate()
            {
                amount = req.amount,
                deadline = req.deadline,
                dealDate = DateTime.Now,
                prID = req.prID,
                FRemail = req.FRemail,
                allId = Guid.NewGuid(),
                status = "Ongoing"
            };
            await biddb.allo.AddAsync(allow);
            await biddb.SaveChangesAsync();
            return RedirectToAction("done");
        }

    }
}
