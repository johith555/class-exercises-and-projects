// Follows Single Responsibility Principle (SRP).
// Responsible only for generating report content.


using Interfaces;

namespace Services;

public class ReportGenerator : IReportGenerator
{
    public string Generate()
    {
        return "Report Content Generated";
    }
}