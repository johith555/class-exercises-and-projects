using System.ComponentModel.DataAnnotations;

namespace Project_Management.Models
{
    public class TaskModel
    {
        [Key]   // ✅ VERY IMPORTANT
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; } = string.Empty;

        public int ProjectId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;

        public DateTime AllocationDate { get; set; }

        public DateTime DeadlineDate { get; set; }
    }
}