using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            try
            {
                Console.WriteLine("\nKalkulator operacji matematycznych");
                Console.WriteLine("Wybierz operację: Dodawanie, Odejmowanie, Mnożenie, Dzielenie");
                string input = Console.ReadLine();

                if (!Enum.TryParse(input, true, out Operation operation))
                {
                    Console.WriteLine("Nieprawidłowa operacja. Spróbuj ponownie.");
                    continue;
                }

                Console.Write("Podaj pierwszą liczbę: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"Wynik: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Nieprawidłowy format liczby. Spróbuj ponownie.");
            }
            catch (DivideByZeroException)
            {
            }

            Console.WriteLine("\nChcesz zobaczyć historię wyników? (tak/nie)");
            string showHistory = Console.ReadLine()?.ToLower();
            if (showHistory == "tak")
            {
                calculator.ShowHistory();
            }

            Console.WriteLine("\nChcesz kontynuować? (tak/nie)");
            string continueCalculation = Console.ReadLine()?.ToLower();
            if (continueCalculation != "tak")
            {
                break;
            }
        }
    }
}
