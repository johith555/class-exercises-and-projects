using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class Library
    {
        public List<Book> Books { get; }
        public List<Borrower> Borrowers { get; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn)
                ?? throw new InvalidOperationException("Book not found.");

            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber)
                ?? throw new InvalidOperationException("Borrower not found.");

            book.Borrow();
            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn)
                ?? throw new InvalidOperationException("Book not found.");

            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber)
                ?? throw new InvalidOperationException("Borrower not found.");

            book.Return();
            borrower.ReturnBook(book);
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}