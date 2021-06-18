using Microsoft.EntityFrameworkCore;

namespace fristProject.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> categories {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost\SQLEXPRESS;Database=fristProject;Trusted_Connection=True");
        }
    }
}