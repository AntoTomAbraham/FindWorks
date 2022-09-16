using Microsoft.EntityFrameworkCore;

namespace studentFreelance.Models
{
    public class ClientDBcontext : DbContext
    {
        public ClientDBcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> client { get; set; }
    }
}
