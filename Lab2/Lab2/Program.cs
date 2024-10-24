using System.Drawing;
using System;
using System.Threading.Channels;
using System.Collections.Concurrent;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System;


namespace SharpLab;
// Zad 1
//{
//    internal class Person
//    {
//        private string firstName;
//        private string lastName;
//        private int age;

//        public Person(string firstName, string lastName, int age)
//        {
//            this.firstName = firstName;
//            this.lastName = lastName;
//            this.age = age;
//        }

//        public string FirstName
//        {
//            get { return firstName; }
//            set
//            {
//                if (value.Length < 2)
//                {
//                    //Console.WriteLine($"Imie musi miec co najmniej 2 znaki");
//                    throw new ArgumentException($"Imie musi miec co najmniej 2 znaki");
//                }
//                firstName = value;
//            }
//        }

//        public string LastName
//        {
//            get { return lastName; }
//            set
//            {
//                if (value.Length < 2)
//                {
//                    throw new ArgumentException($"Nazwisko musi miec co najmniej 2 znaki");
//                }
//                lastName = value;
//            }
//        }


//        public int Age
//        {
//            get { return age; }
//            set
//            {
//                if (age <= 0) throw new ArgumentException($"wiek musi byc liczba dodatnia");
//            }
//        }

//        public void View()
//        {
//            Console.WriteLine($"Imie: {firstName} \tNazwisko: {lastName} \twiek {age}");
//        }
//    }
//}



//zad2
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Tworzenie nowego konta bankowego z właścicielem i początkowym saldem
//        BankAccount konto = new BankAccount("Jan Kowalski", 1000);

//        // Dokonanie wpłaty i wypłaty
//        konto.Wplata(500);    // Saldo: 1500
//        konto.Wyplata(200);   // Saldo: 1300

//        // Wyświetlenie aktualnego salda
//        Console.WriteLine($"Saldo: {konto.Saldo}");
//    }
//}




// zad3

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student1 = new Student("Jan", "Kowalski");

//        student1.DodajOcene(4);
//        student1.DodajOcene(5);
//        student1.DodajOcene(3);

//        student1.WyswietlOceny();
//        Console.WriteLine($"Średnia ocen: {student1.SredniaOcen:F2}");



//        Student student2 = new Student("Pawel", "Kowalski");

//        student2.DodajOcene(3);
//        student2.DodajOcene(5);
//        student2.DodajOcene(2);

//        student2.WyswietlOceny();
//        Console.WriteLine($"Średnia ocen: {student2.SredniaOcen:F2}");
//    }
//}



//zad4
class Program
{
    static void Main(string[] args)
    {
        Liczby liczba1 = new Liczby(50);
        liczba1.WypiszStan();
        
        liczba1.Dodaj(20);
        liczba1.WypiszStan();

        liczba1.Odejmij(10);
        liczba1.WypiszStan(); 

        Liczby liczba2 = new Liczby(100);
        liczba2.WypiszStan(); 

        
        liczba2.Dodaj(50);
        liczba2.WypiszStan(); 

        liczba2.Odejmij(25);
        liczba2.WypiszStan();
    }
}