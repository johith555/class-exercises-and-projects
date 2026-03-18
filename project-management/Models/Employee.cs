namespace Project_Management.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int? ProjectId { get; set; }
    }
}
