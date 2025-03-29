using Microsoft.EntityFrameworkCore;

namespace My_Practice_MVC_App.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; } // Database table for Person
    }
}
