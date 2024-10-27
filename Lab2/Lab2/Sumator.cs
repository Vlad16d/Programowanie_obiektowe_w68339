using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SharpLab;
using System;

public class Sumator
{
    private int[] Liczby;

    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }

    public void WszystkieElementy()
    {
        Console.WriteLine("Elementy tablicy:");
        foreach (int liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    public void ElementyWZakresie(int lowIndex, int highIndex)
    {
        Console.WriteLine($"Elementy od indeksu {lowIndex} do {highIndex}:");
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < Liczby.Length) 
            {
                Console.Write(Liczby[i] + " ");
            }
        }
        Console.WriteLine();
    }
}

