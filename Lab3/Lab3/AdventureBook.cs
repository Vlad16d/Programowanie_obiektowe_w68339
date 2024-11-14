using System;

public class AdventureBook : Book
{
    public string AdventureType { get; private set; }

    // Zmieniamy konstruktor, aby używał publicationYear jako int
    public AdventureBook(string title, Person author, int publicationYear, string adventureType)
        : base(title, author, publicationYear) // Przekazujemy publicationYear do konstruktora Book
    {
        AdventureType = adventureType;
    }

    // Nadpisujemy metodę View
    public override void View()
    {
        base.View();
        Console.WriteLine($"Adventure Type: {AdventureType}");
    }
}
