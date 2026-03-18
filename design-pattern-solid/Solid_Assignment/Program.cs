using Services;
using Formatters;
using Models;

// ===== SOLID Demonstration =====

// SRP + DIP + OCP
var generator = new ReportGenerator();
var formatter = new PdfFormatter();
var saver = new ReportSaver();

var service = new ReportService(generator, formatter, saver);
service.ProcessReport();

Console.WriteLine();

// ===== LSP Demonstration =====
Report sales = new SalesReport();
Report inventory = new InventoryReport();

Console.WriteLine("LSP Demonstration:");
Console.WriteLine(sales.GetReportType());
Console.WriteLine(inventory.GetReportType());