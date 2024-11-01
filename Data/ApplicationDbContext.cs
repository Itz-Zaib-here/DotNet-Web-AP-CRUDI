using Microsoft.EntityFrameworkCore;
using webapi1.Models.Entities;

namespace webapi1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees{ get; set; }
    }
}
