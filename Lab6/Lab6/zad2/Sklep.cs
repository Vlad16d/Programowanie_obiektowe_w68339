using System;
using System.Collections.Generic;

public class Sklep
{
    private Dictionary<int, Zamowienie> zamowienia = new Dictionary<int, Zamowienie>();

    public void DodajZamowienie(int numerZamowienia, List<string> produkty)
    {
        if (zamowienia.ContainsKey(numerZamowienia))
        {
            Console.WriteLine($"Zamówienie o numerze {numerZamowienia} już istnieje!");
            return;
        }

        var noweZamowienie = new Zamowienie(numerZamowienia, produkty, StatusZamowienia.Oczekujące);
        zamowienia.Add(numerZamowienia, noweZamowienie);
        Console.WriteLine($"Dodano nowe zamówienie o numerze {numerZamowienia}.");
    }

    public void ZmienStatus(int numerZamowienia, StatusZamowienia nowyStatus)
    {
        try
        {
            if (!zamowienia.ContainsKey(numerZamowienia))
            {
                throw new KeyNotFoundException($"Nie znaleziono zamówienia o numerze {numerZamowienia}.");
            }

            var zamowienie = zamowienia[numerZamowienia];
            if (zamowienie.Status == nowyStatus)
            {
                throw new ArgumentException($"Zamówienie już ma status {nowyStatus}.");
            }

            zamowienie.Status = nowyStatus;
            Console.WriteLine($"Zmieniono status zamówienia {numerZamowienia} na {nowyStatus}.");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }

    public void WyswietlZamowienia()
    {
        if (zamowienia.Count == 0)
        {
            Console.WriteLine("Brak zamówień.");
            return;
        }

        Console.WriteLine("Lista zamówień:");
        foreach (var zamowienie in zamowienia.Values)
        {
            Console.WriteLine($"Numer: {zamowienie.NumerZamowienia}, Status: {zamowienie.Status}, Produkty: {string.Join(", ", zamowienie.Produkty)}");
        }
    }
}
