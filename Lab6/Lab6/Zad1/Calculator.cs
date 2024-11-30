using System;
using System.Collections.Generic;

public class Calculator
{
    private List<double> results = new List<double>();

  
    public double PerformOperation(double num1, double num2, Operation operation)
    {
        double result = 0;

        try
        {
            switch (operation)
            {
                case Operation.Dodawanie:
                    result = num1 + num2;
                    break;
                case Operation.Odejmowanie:
                    result = num1 - num2;
                    break;
                case Operation.Mnożenie:
                    result = num1 * num2;
                    break;
                case Operation.Dzielenie:
                    if (num2 == 0)
                        throw new DivideByZeroException();
                    result = num1 / num2;
                    break;
                default:
                    throw new ArgumentException("Nieznana operacja.");
            }

            results.Add(result); 
            return result;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Błąd: Dzielenie przez zero nie jest możliwe.");
            throw;
        }
    }

    public void ShowHistory()
    {
        if (results.Count == 0)
        {
            Console.WriteLine("Brak zapisanych wyników.");
        }
        else
        {
            Console.WriteLine("Historia wyników:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
