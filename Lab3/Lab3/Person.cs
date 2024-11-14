using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Wiek { get; set; }

    public Person(string firstName, string lastName, int wiek)
    {
        FirstName = firstName;
        LastName = lastName;
        Wiek = wiek;
    }

    public virtual void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Wiek}");
    }
}
