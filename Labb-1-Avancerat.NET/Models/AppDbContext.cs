using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Labb_1_Avancerat.NET.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 1, FirstName = "Lucas", LastName = "Narfgren", Email = "narfgren@hotmail.com", Books = new List<Book>() });

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Drama" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Action" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Komedi" });

            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, BookTitle = "Svanen", CategoryId = 1 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, BookTitle = "Pistolen", CategoryId = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, BookTitle = "Nakna Pistolen", CategoryId = 3 });
        }

    }
}
