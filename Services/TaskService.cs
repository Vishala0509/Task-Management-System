using TaskBoard.Data;
using TaskBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskBoard.Services
{
    public class TaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> GetTasksAsync()
        {
            return await _context.TaskItems.ToListAsync();
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            _context.TaskItems.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task != null)
            {
                _context.TaskItems.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
