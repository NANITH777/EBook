using EBook.Models;
using Microsoft.EntityFrameworkCore;

namespace EBook.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        /*Pour implementer les donnees dans un tableau de la base de donnee sur Core on utullise la fonction
        protected override void OnModelCreating(ModelBuilder modelBuilder){}*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
