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

        public async Task<IActionResult> viewproject(Guid id)
        {
            ViewBag.MyString = id;
            var pro = await _context.project.FirstOrDefaultAsync(m => m.prID == id);
            if (pro == null) { }
            return View(pro);
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
        [HttpPost]
        public async Task<IActionResult> allocateWork(Project pro)
        {
            var ent = _context.Set<Project>().SingleOrDefault(u => u.prID == pro.prID);
            ent.status = "allocated";
            _context.Entry(ent).Property(x => x.status).IsModified = true;
            //var pr = _context.project.Where(u => u.prID == prId).FirstOrDefault();
            //pr.status = "allocated";
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> makeAllocated(Guid id)
        {
            ViewBag.MyString = id;
            var pro = await _context.project.FirstOrDefaultAsync(m => m.prID == id);
            if(pro == null) { }
            return View(pro);
        }
        [HttpPost]
        public async Task<IActionResult> makeAllocated(Project pro)
        {
            var proj = await _context.project.FindAsync(pro.prID);
            if (proj != null) {
                proj.email = @User.Identity?.Name;
                proj.desc = pro.desc;
                proj.title = pro.title;
                proj.amount = pro.amount;
                proj.status = "Allocated";
                proj.deadline = pro.deadline;
                proj.prID = pro.prID;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> makeDeleted(Guid id)
        {
            ViewBag.MyString = id;
            var pro = await _context.project.FirstOrDefaultAsync(m => m.prID == id);
            if (pro == null) { }
            return View(pro);
        }
        [HttpPost]
        public async Task<IActionResult> makeDeleted(Project pro)
        {
            var proj = await _context.project.FindAsync(pro.prID);
            if (proj != null)
            {
                proj.email = @User.Identity?.Name;
                proj.desc = pro.desc;
                proj.title = pro.title;
                proj.amount = pro.amount;
                proj.status = "Deleted";
                proj.deadline = pro.deadline;
                proj.prID = pro.prID;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Deleted(Guid id)
        {

            var freelancer = await _context.project
               .FirstOrDefaultAsync(m => m.prID == id);
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
