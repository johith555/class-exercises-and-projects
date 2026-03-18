using Interfaces;

namespace Services;

public class ReportSaver : IReportSaver
{
    public void Save(string content)
    {
        Console.WriteLine("Saving Report:");
        Console.WriteLine(content);
    }
}