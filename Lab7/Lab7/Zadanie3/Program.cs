using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "pesels.txt";

        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"Plik '{fileName}' nie istnieje. Upewnij się, że plik został wygenerowany.");
                return;
            }

            List<string> pesels = new List<string>(File.ReadAllLines(fileName));

            int femaleCount = CountFemalePesels(pesels);

            Console.WriteLine($"Liczba żeńskich numerów PESEL: {femaleCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
    }

    static int CountFemalePesels(List<string> pesels)
    {
        int count = 0;

        foreach (string pesel in pesels)
        {
            if (IsFemalePesel(pesel))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsFemalePesel(string pesel)
    {
        if (pesel.Length != 11)
        {
            Console.WriteLine($"Nieprawidłowy PESEL: {pesel}");
            return false;
        }

        char genderDigit = pesel[9];
        return genderDigit % 2 == 0;
    }
}
