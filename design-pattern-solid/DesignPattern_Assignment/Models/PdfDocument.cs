using DesignPattern_Assignment.Interfaces;

namespace DesignPattern_Assignment.Models;

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}