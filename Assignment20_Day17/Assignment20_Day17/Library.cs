using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ViewAllBooks()
    {
        Console.WriteLine("All Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"\nBook ID: {book.BookId}\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nAvailable: {(book.IsAvailable ? "Yes" : "No")}");
        }
    }

    public void SearchBookById(int bookId)
    {
        var book = books.Find(b => b.BookId == bookId);
        if (book != null)
        {
            Console.WriteLine($"\nBook ID: {book.BookId}\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nAvailable for Borrowing: {(book.IsAvailable ? "Yes" : "No")}");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void SearchBookByTitle(string title)
    {
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            Console.WriteLine($"\nBook ID: {book.BookId}\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nAvailable: {(book.IsAvailable ? "Yes" : "No")}");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
}