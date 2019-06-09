using Microsoft.EntityFrameworkCore;

namespace dotnetHelloWorld.Models
{
    public class VisitorsDbContext : DbContext
    {
        public VisitorsDbContext(DbContextOptions options) : base(options)
        {
        }
//testing the branching strategy in git - by developer 1
        public DbSet<Visitor> Visitors { get; set; }
    }
}
