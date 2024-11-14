using System;

public class DocumentaryBook : Book
{
    public string Topic { get; private set; }

    // Zmieniamy konstruktor, aby używał publicationYear jako int
    public DocumentaryBook(string title, Person author, int publicationYear, string topic)
        : base(title, author, publicationYear) // Przekazujemy publicationYear do konstruktora Book
    {
        Topic = topic;
    }

    // Nadpisujemy metodę View
    public override void View()
    {
        base.View();
        Console.WriteLine($"Topic: {Topic}");
    }
}
