using System;

public class DocumentaryBook : Book
{
    public string Topic { get; private set; }

    public DocumentaryBook(string title, Person author, int publicationYear, string topic)
        : base(title, author, publicationYear) 
    {
        Topic = topic;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Topic: {Topic}");
    }
}
