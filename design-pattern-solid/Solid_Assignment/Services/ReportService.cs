// ReportService demonstrates Dependency Inversion Principle (DIP).
// It depends on abstractions (interfaces) rather than concrete implementations.
// Dependencies are injected via constructor.

using Interfaces;

namespace Services;

public class ReportService
{
    private readonly IReportGenerator _generator;
    private readonly IReportFormatter _formatter;
    private readonly IReportSaver _saver;

    public ReportService(
        IReportGenerator generator,
        IReportFormatter formatter,
        IReportSaver saver)
    {
        _generator = generator;
        _formatter = formatter;
        _saver = saver;
    }

    public void ProcessReport()
    {
        var content = _generator.Generate();
        var formatted = _formatter.Format(content);
        _saver.Save(formatted);
    }
}