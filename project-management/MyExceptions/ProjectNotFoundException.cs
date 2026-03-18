namespace Project_Management.MyExceptions
{
    public class ProjectNotFoundException : Exception
    {
        public ProjectNotFoundException(string msg) : base(msg) { }
    }
}
