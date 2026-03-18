

// Base class for demonstrating Liskov Substitution Principle (LSP).
// Derived classes can be substituted wherever Report is expected.
namespace Models;

public abstract class Report
{
    public abstract string GetReportType();
}