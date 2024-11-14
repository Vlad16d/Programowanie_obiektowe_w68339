using System;

public class Book
{
    private string title;
    private Person author;
    private DateTime publicationDate; // Zmieniamy na DateTime

    public string Title
    {
        get { return title; }
        private set { title = value; }
    }

    public Person Author
    {
        get { return author; }
        private set { author = value; }
    }

    public DateTime PublicationDate
    {
        get { return publicationDate; }
        private set { publicationDate = value; }
    }

    // Zmieniamy konstruktor, aby przyjmował rok jako int i tworzył DateTime
    public Book(string title, Person author, int publicationYear)
    {
        Title = title;
        Author = author;
        // Tworzymy obiekt DateTime z przekazanego roku (domyślnie ustawiamy dzień na 1 stycznia)
        PublicationDate = new DateTime(publicationYear, 1, 1);
    }

    // Metoda View() wyświetlająca tytuł, autora i rok publikacji
    public virtual void View()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author.FirstName} {Author.LastName}, Year: {PublicationDate.Year}");
    }
}
