using Interfaces;

namespace Formatters;

public class ExcelFormatter : IReportFormatter
{
    public string Format(string content)
    {
        return $"Excel Format: {content}";
    }
}