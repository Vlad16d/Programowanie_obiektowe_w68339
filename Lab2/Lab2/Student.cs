using System;
using System.Collections.Generic;
using System.Linq;

//zad3
//public class Student
//{
//    public string Imie { get; private set; }
//    public string Nazwisko { get; private set; }

//    private List<int> Oceny;

//    public double SredniaOcen
//    {
//        get
//        {
//            if (Oceny.Count == 0)
//            {
//                return 0; 
//            }
//            return Oceny.Average(); 
//        }
//    }

//    public Student(string imie, string nazwisko)
//    {
//        Imie = imie;
//        Nazwisko = nazwisko;
//        Oceny = new List<int>(); 
//    }

//    public void DodajOcene(int ocena)
//    {
//        if (ocena >= 1 && ocena <= 5)
//        {
//            Oceny.Add(ocena);
//        }
//        else
//        {
//            Console.WriteLine("Ocena musi być w zakresie od 1 do 5.");
//        }
//    }

//    public void WyswietlOceny()
//    {
//        if (Oceny.Count == 0)
//        {
//            Console.WriteLine("Brak ocen.");
//        }
//        else
//        {
//            Console.WriteLine("Oceny studenta: " + string.Join(", ", Oceny));
//        }
//    }
//}
