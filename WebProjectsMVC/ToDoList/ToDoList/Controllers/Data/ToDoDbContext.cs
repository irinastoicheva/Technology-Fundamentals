namespace ToDoList.Controllers.Data
{
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class ToDoDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ToDoListDb;Integrated security=True";
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
