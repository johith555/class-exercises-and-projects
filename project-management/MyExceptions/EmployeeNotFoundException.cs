namespace Project_Management.MyExceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(string msg) : base(msg) { }
    }
}
