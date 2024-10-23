using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//zad2
namespace SharpLab;
using System;

public class BankAccount
{
    // Prywatne pole do przechowywania salda
    private decimal saldo;

    // Publiczna właściwość do odczytu salda
    public decimal Saldo
    {
        get { return saldo; }
    }

    // Publiczna właściwość dla właściciela konta
    public string Wlasciciel { get; private set; }

    // Konstruktor, który ustawia właściciela i początkowe saldo
    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }

    // Metoda do wpłaty na konto
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wpłaty musi być większa niż 0.");
        }
        saldo += kwota;
        Console.WriteLine($"Wpłacono: {kwota}. Nowe saldo: {saldo}");
    }

    // Metoda do wypłaty z konta
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            throw new ArgumentException("Kwota wypłaty musi być większa niż 0.");
        }

        if (kwota > saldo)
        {
            throw new InvalidOperationException("Brak wystarczających środków na koncie.");
        }

        saldo -= kwota;
        Console.WriteLine($"Wypłacono: {kwota}. Nowe saldo: {saldo}");
    }
}

