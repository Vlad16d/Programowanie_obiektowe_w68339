using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Person author1 = new Person("John", "Doe", 40);
        Person author2 = new Person("Jane", "Smith", 35);

        Book book1 = new Book("The Great Adventure", author1, 2020);
        Book book2 = new Book("Mystery of the Lost City", author2, 2022);

        
        Reader reader1 = new Reader("Alice", "Johnson", 28);
        Reader reader2 = new Reader("Bob", "Brown", 30);

    
        reader1.AddBook(book1);
        reader1.AddBook(book2);

        reader2.AddBook(book1);

 
        Reviewer reviewer1 = new Reviewer("Charlie", "Williams", 33);
        reviewer1.AddBook(book1);
        reviewer1.AddBook(book2);

        List<Person> people = new List<Person> { reader1, reader2, reviewer1 };


        foreach (var person in people)
        {
            person.View();
        }

        reviewer1.ViewWithRatings();
    }
}
