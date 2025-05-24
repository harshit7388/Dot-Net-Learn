using Api_test_code.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_test_code.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                    : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
