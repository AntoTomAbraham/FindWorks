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
        public BidController(GigDbcontext biddB)
        {
            this.biddb = biddB;
        }
        
        public async Task<IActionResult> Index(Guid id)
        {
            ids = id;
            ViewBag.MyString = id;
            ids = ViewBag.MyString;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Bids req)
        {
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
            return RedirectToAction("Index");
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
            return RedirectToAction("viewMyBids");
        }

    }
}
