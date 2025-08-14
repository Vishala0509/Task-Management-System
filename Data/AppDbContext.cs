using Microsoft.EntityFrameworkCore;
using TaskBoard.Models;

namespace TaskBoard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> TaskItems { get; set; } = default!;
    }
}
