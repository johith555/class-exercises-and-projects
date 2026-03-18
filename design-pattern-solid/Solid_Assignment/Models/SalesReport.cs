namespace Models;

public class SalesReport : Report
{
    public override string GetReportType()
    {
        return "Sales Report";
    }
}