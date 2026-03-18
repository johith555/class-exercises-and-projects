using DesignPattern_Assignment.Interfaces;

namespace DesignPattern_Assignment.Models;

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}