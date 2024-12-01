using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj nazwę pliku do odczytu (np. 'album.txt'):");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                string fileContent = File.ReadAllText(fileName);
                Console.WriteLine("Zawartość pliku:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine($"Plik o nazwie '{fileName}' nie istnieje.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
    }
}
