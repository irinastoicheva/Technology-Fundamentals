using Microsoft.EntityFrameworkCore;

namespace TeisterMask.Models
{
    public class MeisterTaskDbContext: DbContext
    {
        private const string ConnectionString = @"Server= DESKTOP-3M5SEK3\SQLEXPRESS;Database=MeisterTaskDbContext;Integrated security=True";
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
