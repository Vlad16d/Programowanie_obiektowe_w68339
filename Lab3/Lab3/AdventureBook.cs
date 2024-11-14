using System;

public class AdventureBook : Book
{
    public string AdventureType { get; private set; }

    public AdventureBook(string title, Person author, int publicationYear, string adventureType)
        : base(title, author, publicationYear) 
    {
        AdventureType = adventureType;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Adventure Type: {AdventureType}");
    }
}
