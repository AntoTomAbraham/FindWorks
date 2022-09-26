using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentFreelance.Models;
using System.Reflection;

namespace studentFreelance.Controllers
{
    public class ProjectController : Controller
    {
        private readonly FreelancerDBcontext _context;
        public ProjectController(FreelancerDBcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Project req)
        {
            var project = new Project()
            {
                title = req.title,
                amount = req.amount,
                desc = req.desc,
                status = "true",
                email = @User.Identity?.Name,
                deadline = req.deadline,
            };
            await _context.project.AddAsync(project);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }

        public async Task<IActionResult> viewmyProjects()
        {
            return View(await _context.project.ToListAsync());
        }

        public async Task<IActionResult> viewProjects()
        {
            return _context.freelancer != null ?
                        View(await _context.project.ToListAsync()) :
                        Problem("Entity set 'FreelancerDBcontext.freelancer'  is null.");
        }

    }
}
