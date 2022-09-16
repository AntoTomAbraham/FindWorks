using Microsoft.EntityFrameworkCore;

namespace studentFreelance.Models
{
    public class GigDbcontext:DbContext
    {
        public GigDbcontext(DbContextOptions<GigDbcontext> options) : base(options)
        {

        }

        public DbSet<Gig> gig { get; set; }
    }
}
