using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj nazwę pliku (z rozszerzeniem, np. 'album.txt'):");
            string fileName = Console.ReadLine();

            Console.WriteLine("Podaj numer albumu:");
            string albumNumber = Console.ReadLine();

            File.WriteAllText(fileName, albumNumber);

            Console.WriteLine($"Numer albumu został zapisany w pliku '{fileName}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
    }
}
