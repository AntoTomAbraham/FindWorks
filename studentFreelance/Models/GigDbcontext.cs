using Microsoft.EntityFrameworkCore;

namespace studentFreelance.Models
{
    public class GigDbcontext:DbContext
    {
        public GigDbcontext(DbContextOptions<GigDbcontext> options) : base(options)
        {

        }

        public DbSet<Gig> gig { get; set; }
        public DbSet<Bids> bids { get; set; }
        public DbSet<Allocate> allo { get; set; }
    }
}
