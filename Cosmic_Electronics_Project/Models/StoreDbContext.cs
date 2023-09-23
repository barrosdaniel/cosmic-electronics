using Microsoft.EntityFrameworkCore;

namespace Cosmic_Electronics_Project.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
