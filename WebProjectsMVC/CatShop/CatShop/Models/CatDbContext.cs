namespace CatShop.Models
{
    using Microsoft.EntityFrameworkCore;
    using CatShop.Models;

    public class CatDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=CatDbContext;Integrated security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        //public CatDbContext()
        //{
        //    this.Database.EnsureCreated();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=catshop_csharp;user=root;");
        //}
    }
}
