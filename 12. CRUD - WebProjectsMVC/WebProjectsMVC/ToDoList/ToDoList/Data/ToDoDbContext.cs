using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
    public class ToDoDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ToDoListDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
