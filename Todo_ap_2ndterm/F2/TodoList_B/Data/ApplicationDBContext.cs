using Microsoft.EntityFrameworkCore;

using TodoList_B.Model;
namespace TodoList_B.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {

        }
        //create tables...tasks=name of the table
        public DbSet<Todo> Tasks { get; set; }
        public DbSet<TodoList> List { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
