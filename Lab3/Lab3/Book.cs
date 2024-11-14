using System;

public class Book
{
    private string title;
    private Person author;
    private DateTime publicationDate;

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

    
    public Book(string title, Person author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationDate = new DateTime(publicationYear, 1, 1);
    }

    public virtual void View()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author.FirstName} {Author.LastName}, Year: {PublicationDate.Year}");
    }
}
