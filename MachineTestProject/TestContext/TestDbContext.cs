using MachineTestProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MachineTestProject.TestContext
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options): base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; } 
    }
}
