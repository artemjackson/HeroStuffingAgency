using Microsoft.Data.Entity;

namespace HeroesStaffingAgency.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
    }
}
