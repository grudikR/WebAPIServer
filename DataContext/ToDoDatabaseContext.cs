using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace WebAPIServer.DataContext
{
    public class ToDoDatabaseContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public ToDoDatabaseContext(DbContextOptions<ToDoDatabaseContext> options):base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
    }
}