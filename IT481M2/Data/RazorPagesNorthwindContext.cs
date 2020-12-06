using Microsoft.EntityFrameworkCore;

namespace IT481M2.Data
{
    public class RazorPagesNorthwindContext : DbContext
    {
        public RazorPagesNorthwindContext(
            DbContextOptions<RazorPagesNorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Customer> Customers { get; set; }
    }
}