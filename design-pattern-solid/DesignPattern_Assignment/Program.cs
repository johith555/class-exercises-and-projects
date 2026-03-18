using DesignPattern_Assignment.Factory;
using DesignPattern_Assignment.Interfaces;

var factory = new DocumentFactory();

IDocument pdfDoc = factory.CreateDocument("pdf");
pdfDoc.Open();

IDocument wordDoc = factory.CreateDocument("word");
wordDoc.Open();