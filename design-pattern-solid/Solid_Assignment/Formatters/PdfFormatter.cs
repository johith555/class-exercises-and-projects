// Implements Open/Closed Principle (OCP).
// New formatters can be added without modifying existing code.



using Interfaces;

namespace Formatters;

public class PdfFormatter : IReportFormatter
{
    public string Format(string content)
    {
        return $"PDF Format: {content}";
    }
}