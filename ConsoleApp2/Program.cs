﻿using System.Drawing;
using System;
using System.Threading.Channels;
using System.Collections.Concurrent;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;

//int a = 4;
//float fa = 2.34f;
//double da = 4.1212323;
//char znak = 'a';
//string s = "Jan";

//bool value= false;

//Console.WriteLine(a);
//Console.WriteLine(fa);
//Console.WriteLine(da);
//Console.WriteLine(znak);
//Console.WriteLine(s);
//Console.WriteLine(value);

//Console.WriteLine("Siema!");
//int a, b = 4;
//string name;
//Console.WriteLine("Podaj liczbe: ");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Podaj imie: ");
//name = Console.ReadLine();

//double liczba = 123.41231221;
//Console.WriteLine("Liczba: "+ Math.Round(liczba,2));
//Console.WriteLine($"Liczba: {liczba:F2}");


//int[] tabint = { 12, 21, 123 };

//for (int i = 0; i < tabint.Length; i++)
//{
//    Console.WriteLine(" i = " + i);
//}

//foreach (int i in tabint)
//{
//    Console.WriteLine(i);
//}



//Napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.
//zadanie1();

//void zadanie1()
//{
//    double a = DoubleInput();
//    double b = DoubleInput();
//    double c = DoubleInput();
//    double x1, x2, delta;
//    if (a == 0) Console.WriteLine("To nie jest rownanie kwadratowe");
//    else
//    {
//        delta = (Math.Pow(b, 2) - (4 * a * c));
//        if (delta > 0)
//        {
//            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine($"Dwa rozwiazania, x1 = {x1}, x2 = {x2}");
//        }
//        else if (delta == 0)
//        {
//            x1 = -b / (2 * a);
//            Console.WriteLine($"Jedno rozwiazanie x1 ={x1}");
//        }
//        else Console.WriteLine("Brak rozwiazania w zbiorze liczb rzeczywistych");
//    }
//}

//double DoubleInput()
//{
//    Console.WriteLine("Podaj liczbe: ");
//    double value = Convert.ToDouble(Console.ReadLine());
//    return value;
//}



//Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
//funkcji trygonometrycznych dla zadanego kąta. Użyj biblioteki Math np. Math.Sin(2.5). Proszę
//pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
//algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz
//pętli while.




void menu()
{
    Console.WriteLine("---------- Kalkulator ---------- \n1 Suma\n2 Roznica\n3 Iloczyn\n4 Iloraz\n5 Potegowanie\n6 Pierwiastek\n7 Trygonometria\n8 Wyjscie");
    Console.WriteLine("wubierz opcje: ");
    int choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1: Total(); break;             //Сумма
        case 2: Difference(); break;        //Разность
        case 3: ProductNumber(); break;     //Произведение
        case 4: QuotientNumber(); break;    //Частное
        case 5: PotentialNumber(); break;   //Степень
        case 6: SquartilNumber(); break;    //Корень
        case 7: Trigonometry(); break;    //Тригонометрические значения
        case 8: Close(); break;

        default:
            Console.WriteLine("Bladne dane ");
            break;
    }
}

void Close()
{
    Console.WriteLine("Koniec programu :))");
}

void Total()
{
    Console.WriteLine("Wprowadz ilosc elementow: ");
    int ilosc = int.Parse(Console.ReadLine());

    List<double> variables = new List<double>();

    for (int i = 0; i < ilosc; i++)
    {
        Console.Write($"Wprowadz element {i + 1}: ");
        variables.Add(double.Parse(Console.ReadLine()));
    }

    double sum = 0;
    variables.ForEach(v => sum += v);

    Console.WriteLine($"Suma: {sum}");
}


void Difference()
{
    Console.WriteLine("Wprowadz ilosc elementow: ");
    int ilosc = int.Parse(Console.ReadLine());

    List<double> variables = new List<double>();

    for (int i = 0; i < ilosc; i++)
    {
        Console.Write($"Wprowadz element {i + 1}: ");
        variables.Add(double.Parse(Console.ReadLine()));
    }

    double result = variables[0];
    for (int i = 1; i < variables.Count; i++)
    {
        result -= variables[i];
    }

    Console.WriteLine($"Roznica: {result}");
}

void ProductNumber()
{
    int pn1, pn2;
    Console.WriteLine("Wprowadz 1 liczbe dla mnozenia: ");
    pn1= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wprowadz 2 liczbe dla mnozenia: ");
    pn2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(pn1 * pn2 );
}

void QuotientNumber()
{
    int dz1,dz2;
    Console.WriteLine("Wprowadz 1 liczbe dla podzielenia: ");
    dz1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wprowadz 2 liczbe dla podzielenia: ");
    dz2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(dz1 / dz2);
}

void PotentialNumber()
{
    int a, b;
    Console.WriteLine("Wprowadz liczbe: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wprowadz potega: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Pow(a, b));
}

void SquartilNumber()
{
    int s, b;
    Console.WriteLine("Wprowadz liczbe dla pierwiastka: ");
    s = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Sqrt(s));
}

void Trigonometry()
{
    Console.WriteLine("Wprowadź kąt w stopniach:");
    double degrees = double.Parse(Console.ReadLine());

    double radians = degrees * (Math.PI / 180);

    double sinValue = Math.Sin(radians);
    double cosValue = Math.Cos(radians);
    double tanValue = Math.Tan(radians);

    Console.WriteLine($"Sinus kata {degrees}°: {sinValue}");
    Console.WriteLine($"Kosinus kata {degrees}°: {cosValue}");
    Console.WriteLine($"Tangens kata {degrees}°: {tanValue}");
}

menu();