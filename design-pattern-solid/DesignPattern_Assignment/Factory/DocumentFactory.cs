using DesignPattern_Assignment.Interfaces;
using DesignPattern_Assignment.Models;

namespace DesignPattern_Assignment.Factory;

public class DocumentFactory
{
    public IDocument CreateDocument(string type)
    {
        return type.ToLower() switch
        {
            "pdf" => new PdfDocument(),
            "word" => new WordDocument(),
            _ => throw new ArgumentException("Invalid document type")
        };
    }
}