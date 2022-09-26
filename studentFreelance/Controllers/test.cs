using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;

namespace studentFreelance.Controllers
{
    public class test : Controller
    {
        private readonly FreelancerDBcontext _context;
        public test(FreelancerDBcontext test)
        {
            _context = test;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.test.ToListAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Home()
        {
            var data = await _context.test.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(testQuestionModule req)
        {
            int pointt=0;
            if (req.q1 == "15" ) {
                pointt = pointt + 1;
            }
            if (req.q2 == "Book")
            {
                pointt = pointt + 1;
            }
            if (req.q3 == "Beak")
            {
                pointt = pointt + 1;
            }
            if (req.q4 == "flow")
            {
                pointt = pointt + 1;
            }
            if (req.q5 == "baised")
            {
                pointt = pointt + 1;
            }
            if (req.q6 == "20")
            {
                pointt = pointt + 1;
            }
            if (req.q7 == "important")
            {
                pointt = pointt + 1;
            }
            var test = new testModels()
            {
                email = @User.Identity?.Name,
                point =pointt,
                DateOfSubmission=DateTime.Now

            };
            await _context.test.AddAsync(test);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
