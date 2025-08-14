using System.ComponentModel.DataAnnotations;

namespace TaskBoard.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [StringLength(50, ErrorMessage = "Status cannot exceed 50 characters.")]
        public string Status { get; set; }

        [StringLength(100, ErrorMessage = "AssignedTo cannot exceed 100 characters.")]
        public string? AssignedTo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}