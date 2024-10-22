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


namespace SharpLab
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 2)
                {
                    //Console.WriteLine($"Imie musi miec co najmniej 2 znaki");
                    throw new ArgumentException($"Imie musi miec co najmniej 2 znaki");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Nazwisko musi miec co najmniej 2 znaki");
                }
                lastName = value;
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 0) throw new ArgumentException($"wiek musi byc liczba dodatnia");
            }
        }

        public void View()
        {
            Console.WriteLine($"Imie: {firstName} \tNazwisko {lastName} \twiek {age}");
        }
    }
}