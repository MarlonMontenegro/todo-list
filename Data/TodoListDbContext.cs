using Microsoft.EntityFrameworkCore;
using TodoListApp.Models;

namespace TodoListApp.Data
{
    public class TodoListDbContext : DbContext
    {

        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options) 
        { 

        }
        
        public DbSet<TodoTask> Task { get; set; }




    }
}
