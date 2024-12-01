using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var data = new PopulationData("db.json");

        while (true)
        {
            Console.WriteLine("\nВыберите опцию:");
            Console.WriteLine("1. Разница населения между двумя годами");
            Console.WriteLine("2. Посмотреть население по стране и году");
            Console.WriteLine("3. Разница населения для диапазона лет");
            Console.WriteLine("4. Годовой прирост населения для страны");
            Console.WriteLine("5. Выход");
            Console.Write("Ваш выбор: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите страну: ");
                    var country1 = Console.ReadLine();
                    Console.Write("Введите начальный год: ");
                    var yearStart = Console.ReadLine();
                    Console.Write("Введите конечный год: ");
                    var yearEnd = Console.ReadLine();

                    var difference = data.GetPopulationDifference(country1, yearStart, yearEnd);
                    if (difference.HasValue)
                    {
                        Console.WriteLine($"Разница населения между {yearStart} и {yearEnd} для {country1}: {difference.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Данные не найдены.");
                    }
                    break;

                case "2":
                    Console.Write("Введите страну: ");
                    var country2 = Console.ReadLine();
                    Console.Write("Введите год: ");
                    var year = Console.ReadLine();

                    var population = data.GetPopulation(country2, year);
                    if (population.HasValue)
                    {
                        Console.WriteLine($"Население {country2} в {year}: {population.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Данные не найдены.");
                    }
                    break;

                case "3":
                    Console.Write("Введите страну: ");
                    var country3 = Console.ReadLine();
                    Console.Write("Введите начальный год: ");
                    var startYear = Console.ReadLine();
                    Console.Write("Введите конечный год: ");
                    var endYear = Console.ReadLine();

                    var rangeDifference = data.GetPopulationDifference(country3, startYear, endYear);
                    if (rangeDifference.HasValue)
                    {
                        Console.WriteLine($"Разница населения между {startYear} и {endYear} для {country3}: {rangeDifference.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Данные не найдены.");
                    }
                    break;

                case "4":
                    Console.Write("Введите страну: ");
                    var country4 = Console.ReadLine();
                    var growthRates = data.GetYearlyGrowth(country4);

                    Console.WriteLine($"Годовой прирост населения для {country4}:");
                    foreach (var growth in growthRates)
                    {
                        Console.WriteLine($"Год: {growth.Key}, Прирост: {growth.Value:F2}%");
                    }
                    break;

                case "5":
                    Console.WriteLine("Выход...");
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
