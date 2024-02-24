using Microsoft.EntityFrameworkCore;

namespace Mission06_Ross.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Comedy"},
                new Category { CategoryId = 2, CategoryName = "sports" },
                new Category { CategoryId = 3, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Television" },
                new Category { CategoryId = 6, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 7, CategoryName = "Family" },
                new Category { CategoryId = 8, CategoryName = "Action/Adventure" }
            );
        }
    }
}
