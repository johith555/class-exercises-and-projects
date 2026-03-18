using Microsoft.EntityFrameworkCore;
using Project_Management.Models;

namespace Project_Management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}