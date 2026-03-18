namespace Models;

public class InventoryReport : Report
{
    public override string GetReportType()
    {
        return "Inventory Report";
    }
}