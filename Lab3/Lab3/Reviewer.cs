using System;

public class Reviewer : Reader
{
    private static Random random = new Random();

    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

    public void ViewWithRatings()
    {
        Console.WriteLine($"{FirstName} {LastName} reviews the following books:");
        foreach (var book in BooksRead) // Odwołanie do BooksRead (właściwość w Reader)
        {
            Console.WriteLine($"- {book.Title} (Rating: {random.Next(1, 6)})");
        }
    }
}
