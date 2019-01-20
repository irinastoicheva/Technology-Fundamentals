namespace Library.Data
{
    using Library.Models;
    using Microsoft.EntityFrameworkCore;

    public class LibraryDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=LibraryDb;Integrated security=True";
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
