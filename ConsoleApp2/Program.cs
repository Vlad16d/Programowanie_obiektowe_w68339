﻿using System.Drawing;
using System;
using System.Threading.Channels;
using System.Collections.Concurrent;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

//ZADANIE1
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





// ZADANIE 2
//void menu()
//{
//    Console.WriteLine("---------- Kalkulator ---------- \n1 Suma\n2 Roznica\n3 Iloczyn\n4 Iloraz\n5 Potegowanie\n6 Pierwiastek\n7 Trygonometria\n8 Wyjscie");
//    Console.WriteLine("wubierz opcje: ");
//    int choise = Convert.ToInt32(Console.ReadLine());

//    switch (choise)
//    {
//        case 1: Total(); break;             //Сумма
//        case 2: Difference(); break;        //Разность
//        case 3: ProductNumber(); break;     //Произведение
//        case 4: QuotientNumber(); break;    //Частное
//        case 5: PotentialNumber(); break;   //Степень
//        case 6: SquartilNumber(); break;    //Корень
//        case 7: Trigonometry(); break;    //Тригонометрические значения
//        case 8: Close(); break;

//        default:
//            Console.WriteLine("Bladne dane ");
//            break;
//    }
//}

//void Close()
//{
//    Console.WriteLine("Koniec programu :))");
//}

//void Total()
//{
//    Console.WriteLine("Wprowadz ilosc elementow: ");
//    int ilosc = int.Parse(Console.ReadLine());

//    List<double> variables = new List<double>();

//    for (int i = 0; i < ilosc; i++)
//    {
//        Console.Write($"Wprowadz element {i + 1}: ");
//        variables.Add(double.Parse(Console.ReadLine()));
//    }

//    double sum = 0;
//    variables.ForEach(v => sum += v);

//    Console.WriteLine($"Suma: {sum}");
//}


//void Difference()
//{
//    Console.WriteLine("Wprowadz ilosc elementow: ");
//    int ilosc = int.Parse(Console.ReadLine());

//    List<double> variables = new List<double>();

//    for (int i = 0; i < ilosc; i++)
//    {
//        Console.Write($"Wprowadz element {i + 1}: ");
//        variables.Add(double.Parse(Console.ReadLine()));
//    }

//    double result = variables[0];
//    for (int i = 1; i < variables.Count; i++)
//    {
//        result -= variables[i];
//    }

//    Console.WriteLine($"Roznica: {result}");
//}

//void ProductNumber()
//{
//    int pn1, pn2;
//    Console.WriteLine("Wprowadz 1 liczbe dla mnozenia: ");
//    pn1= Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Wprowadz 2 liczbe dla mnozenia: ");
//    pn2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(pn1 * pn2 );
//}

//void QuotientNumber()
//{
//    int dz1,dz2;
//    Console.WriteLine("Wprowadz 1 liczbe dla podzielenia: ");
//    dz1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Wprowadz 2 liczbe dla podzielenia: ");
//    dz2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(dz1 / dz2);
//}

//void PotentialNumber()
//{
//    int a, b;
//    Console.WriteLine("Wprowadz liczbe: ");
//    a = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Wprowadz potega: ");
//    b = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Math.Pow(a, b));
//}

//void SquartilNumber()
//{
//    int s, b;
//    Console.WriteLine("Wprowadz liczbe dla pierwiastka: ");
//    s = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Math.Sqrt(s));
//}

//void Trigonometry()
//{
//    Console.WriteLine("Wprowadź kąt w stopniach:");
//    double degrees = double.Parse(Console.ReadLine());

//    double radians = degrees * (Math.PI / 180);

//    double sinValue = Math.Sin(radians);
//    double cosValue = Math.Cos(radians);
//    double tanValue = Math.Tan(radians);

//    Console.WriteLine($"Sinus kata {degrees}°: {sinValue}");
//    Console.WriteLine($"Kosinus kata {degrees}°: {cosValue}");
//    Console.WriteLine($"Tangens kata {degrees}°: {tanValue}");
//}


//menu();



//ZADANIE 3
//void menu()
//{
//    Console.WriteLine("Dzien dobry! Poprosze o wypelneniu tablice 10 liczb");
//    double[] numbers = new double[10];
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write($"Wprowadź liczbę {i + 1}: ");
//        numbers[i] = double.Parse(Console.ReadLine());
//    }

//    Console.WriteLine("\nTwoja tablica wyglada jako:");

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }

//    Console.WriteLine();

//    Console.WriteLine("\nProsze wybrac zadanie (wprowadz tylko liczbe) :/");
//    Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu. ");
//    Console.WriteLine("2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu.  ");
//    Console.WriteLine("3. Wyświetlanie elementów o nieparzystych indeksach. ");
//    Console.WriteLine("4. Wyświetlanie elementów o parzystych indeksach.  \n");
//    string choise = Console.ReadLine();

//    void kropka1()
//    {
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    }

//    void kropka2()
//    {
//        for (int i = numbers.Length - 1; i >= 0; i--)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    }

//    void kropka3()
//    {
//        for (int i = 0; i < numbers.Length; i=i+2)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    }

//    void kropka4()
//    {
//        for (int i = 1; i < numbers.Length; i = i + 2)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    }

//    if (choise == "1")
//    {
//        Console.WriteLine("\nWyświetlanie tablicy od pierwszego do ostatniego indeksu:");
//        kropka1();
//        Console.WriteLine("\n");
//    }

//    else if (choise == "2")
//    {
//        Console.WriteLine("\nWyświetlanie tablicy od ostatniego do pierwszego indeksu:");
//        kropka2();
//        Console.WriteLine("\n");
//    }

//    else if (choise == "3")
//    {
//        Console.WriteLine("\nWyświetlanie elementów o nieparzystych indeksach:");
//        kropka3();
//        Console.WriteLine("\n");
//    }

//    else if (choise == "4")
//    {
//        Console.WriteLine("\n Wyświetlanie elementów o parzystych indeksach:");
//        kropka4();
//        Console.WriteLine("\n");
//    }

//    else
//    {
//        Console.WriteLine("Błąd! Cos poszlo nie tak, sproboj ponownie :) \n");
//    }
//}

//menu();


//ZADANIE 4
//void tablica()
//{
//    Console.WriteLine("Wprowadz 10 liczb");
//    double[] numbers = new double[10];
//    double sum = 0, iloczyn = 1, srednia = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.WriteLine($"Wprowadz {i+1} element:");
//        numbers[i] = double.Parse(Console.ReadLine());
//    }

//    Console.WriteLine("\nTwoja tablica: ");

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }

//    Console.WriteLine("");

//    for (int i=0; i< numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    Console.WriteLine("\nSuma tablicy: " + sum);

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        iloczyn *= numbers[i];
//    }
//    Console.WriteLine("\nIloczyn tablicy: " + iloczyn);

//    Console.WriteLine("\nSrednia tablicy: " + (sum/10));

//    double min = numbers[0];
//    for (int i=1; i < numbers.Length; i++)
//    {
//        if (numbers[i] < min)
//        {
//            min = numbers[i];
//        }
//    }
//    Console.WriteLine("\nMinimalna tablicy: " + min);

//    double max = numbers[0];
//    for (int i = 1; i < numbers.Length; i++)
//    {
//        if (numbers[i] > max)
//        {
//            max = numbers[i];
//        }
//    }
//    Console.WriteLine("\nMaksymalna tablicy: " + max);

//}

//tablica();



//ZADANIE 5
//void cont()
//{
//    Console.WriteLine("Liczby od 0 do 20 (bez 2,6,9,15,19): ");
//    for (int i = 0; i <=20; i++)
//    {

//        if (i == 2 || i == 6 || i == 9) 
//        {
//            continue; 
//        }

//        if (i == 15 || i == 19)
//        {
//            continue;
//        }
//        Console.WriteLine(i);
//    }
//}

//cont();



//ZADANIE 6
//Napisz program, który w nieskończoność pyta użytkownika o liczby całkowite. Pętla 
//nieskończona powinna się zakończyć gdy użytkownik wprowadzi liczbę mniejszą od zera.

//void wh() { 
//    while (true)
//    { 
//        Console.WriteLine("\nWprowadz liczbe cakowite: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        if ( n < 0)
//        {
//            Console.WriteLine("Stop, liczba jest < 0 :( ");
//            break;
//        }
//        Console.WriteLine("\nTwoja liczba calkowita ktora > 0: " + n);
//    }
//}
//wh();
////lub
//void fr() {

//    for (int i = 0; true; i++)
//    {
//        Console.WriteLine("\nWprowadz liczbe cakowite: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        if (n < 0)
//        {
//            Console.WriteLine("Stop, liczba jest < 0 :( ");
//            break;
//        }
//        Console.WriteLine("\nTwoja liczba calkowita ktora > 0: " + n);
//    }

//}


//fr();



//ZADANIE 7
//Napisz program umożliwiający wprowadzanie n liczb oraz sortujący te liczby metodą 
//bąbelkową lub wstawiania. Wyniki wyświetlaj na konsoli.

Console.WriteLine("Wprowadz ilosc liczb: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Wprowadz {i+1} element: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nWprowadzone liczby:");
for (int i = 0; i < n; i++)
{
    Console.Write(numbers[i] + " ");
}

// BubbleSort
for  (int i = 0;i < n - 1; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("\n\nTablica posortowana:");
for (int i = 0; i < n; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();