using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;

namespace studentFreelance.Controllers
{
    public class freelancersController : Controller
    {
        private readonly FreelancerDBcontext _context;

        public freelancersController(FreelancerDBcontext context)
        {
            _context = context;
        }

        // GET: freelancers
        public async Task<IActionResult> Index()
        {
            return _context.freelancer != null ?
                        View(await _context.freelancer.ToListAsync()):
                          Problem("Entity set 'FreelancerDBcontext.freelancer'  is null.");
        }
        // GET: freelancers
        public async Task<IActionResult> home()
        {
            return View();
        }

        // GET: freelancers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.freelancer == null)
            {
                return NotFound();
            }

            var freelancer = await _context.freelancer
                .FirstOrDefaultAsync(m => m.email == id);
            if (freelancer == null)
            {
                return NotFound();
            }

            return View(freelancer);
        }

        // GET: freelancers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: freelancers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("email,name,skill,phno,balance,college")] freelancer freelancer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(freelancer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(freelancer);
        }

        // GET: freelancers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.freelancer == null)
            {
                return NotFound();
            }

            var freelancer = await _context.freelancer.FindAsync(id);
            if (freelancer == null)
            {
                return NotFound();
            }
            return View(freelancer);
        }

        // POST: freelancers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("email,name,skill,phno,balance,college")] freelancer freelancer)
        {
            if (id != freelancer.email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(freelancer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!freelancerExists(freelancer.email))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(freelancer);
        }

        // GET: freelancers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.freelancer == null)
            {
                return NotFound();
            }

            var freelancer = await _context.freelancer
                .FirstOrDefaultAsync(m => m.email == id);
            if (freelancer == null)
            {
                return NotFound();
            }

            return View(freelancer);
        }

        // POST: freelancers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.freelancer == null)
            {
                return Problem("Entity set 'FreelancerDBcontext.freelancer'  is null.");
            }
            var freelancer = await _context.freelancer.FindAsync(id);
            if (freelancer != null)
            {
                _context.freelancer.Remove(freelancer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool freelancerExists(string id)
        {
          return (_context.freelancer?.Any(e => e.email == id)).GetValueOrDefault();
        }
    }
}
