using Project_Management.Data;
using Project_Management.Models;

namespace Project_Management.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CreateEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return true;
        }
    }
}