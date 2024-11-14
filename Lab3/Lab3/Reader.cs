using System;
using System.Collections.Generic;

public class Reader : Person
{
    private List<Book> booksRead;

    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        booksRead = new List<Book>();
    }
    public IReadOnlyList<Book> BooksRead => booksRead;

    public void AddBook(Book book)
    {
        booksRead.Add(book);
    }

    public void ViewBooks()
    {
        Console.WriteLine($"{FirstName} {LastName} has read the following books:");
        foreach (var book in booksRead)
        {
            Console.WriteLine($"- {book.Title}");
        }
    }

    public override void View()
    {
        base.View();
        ViewBooks();
    }
}
