using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
