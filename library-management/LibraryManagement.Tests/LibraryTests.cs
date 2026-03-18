using System;
using Xunit;
using LibraryManagement.Models;
using LibraryManagement.Services;

namespace LibraryManagement.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var library = new Library();
            var book = new Book("C# Basics", "John Doe", "123");

            library.AddBook(book);

            Assert.Single(library.Books);
            Assert.Equal("123", library.Books[0].ISBN);
        }

        [Fact]
        public void RegisterBorrower_ShouldAddBorrower()
        {
            var library = new Library();
            var borrower = new Borrower("Alice", "CARD1");

            library.RegisterBorrower(borrower);

            Assert.Single(library.Borrowers);
            Assert.Equal("CARD1", library.Borrowers[0].LibraryCardNumber);
        }

        [Fact]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var library = new Library();
            var book = new Book("C# Basics", "John Doe", "123");
            var borrower = new Borrower("Alice", "CARD1");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "CARD1");

            Assert.True(book.IsBorrowed);
            Assert.Single(borrower.BorrowedBooks);
        }

        [Fact]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var library = new Library();
            var book = new Book("C# Basics", "John Doe", "123");
            var borrower = new Borrower("Alice", "CARD1");

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("123", "CARD1");

            library.ReturnBook("123", "CARD1");

            Assert.False(book.IsBorrowed);
            Assert.Empty(borrower.BorrowedBooks);
        }

        [Fact]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var library = new Library();
            library.AddBook(new Book("Book1", "Author1", "1"));
            library.AddBook(new Book("Book2", "Author2", "2"));

            var books = library.ViewBooks();

            Assert.Equal(2, books.Count);
        }

        [Fact]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var library = new Library();
            library.RegisterBorrower(new Borrower("Alice", "1"));
            library.RegisterBorrower(new Borrower("Bob", "2"));

            var borrowers = library.ViewBorrowers();

            Assert.Equal(2, borrowers.Count);
        }
    }
}