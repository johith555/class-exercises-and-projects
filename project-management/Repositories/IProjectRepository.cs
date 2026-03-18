using Project_Management.Models;

namespace Project_Management.Repositories
{
    public interface IProjectRepository
    {
        bool CreateEmployee(Employee emp);
    }
}