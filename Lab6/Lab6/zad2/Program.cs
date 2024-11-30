using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Sklep sklep = new Sklep();

        while (true)
        {
            Console.WriteLine("\nZarządzanie zamówieniami w sklepie");
            Console.WriteLine("1. Dodaj zamówienie");
            Console.WriteLine("2. Zmień status zamówienia");
            Console.WriteLine("3. Wyświetl wszystkie zamówienia");
            Console.WriteLine("4. Wyjście");
            Console.Write("Wybierz opcję: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Console.Write("Podaj numer zamówienia: ");
                    int numer = int.Parse(Console.ReadLine());

                    Console.Write("Podaj produkty (oddzielone przecinkiem): ");
                    List<string> produkty = new List<string>(Console.ReadLine().Split(','));

                    sklep.DodajZamowienie(numer, produkty);
                    break;

                case "2":
                    Console.Write("Podaj numer zamówienia: ");
                    numer = int.Parse(Console.ReadLine());

                    Console.WriteLine("Wybierz nowy status: Oczekujące, Przyjęte, Zrealizowane, Anulowane");
                    string nowyStatus = Console.ReadLine();

                    if (Enum.TryParse(nowyStatus, true, out StatusZamowienia status))
                    {
                        sklep.ZmienStatus(numer, status);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy status.");
                    }
                    break;

                case "3":
                    sklep.WyswietlZamowienia();
                    break;

                case "4":
                    Console.WriteLine("Do widzenia!");
                    return;

                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
