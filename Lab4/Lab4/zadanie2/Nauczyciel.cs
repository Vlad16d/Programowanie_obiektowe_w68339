using System;
using System.Collections.Generic;

public class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; set; }
    public List<Uczen> PodwladniUczniowie { get; private set; }

    public Nauczyciel()
    {
        PodwladniUczniowie = new List<Uczen>();
    }

    public void AddStudent(Uczen uczen)
    {
        PodwladniUczniowie.Add(uczen);
    }

    public override string GetEducationInfo() => $"Nauczyciel z tytułem: {TytulNaukowy}";

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        Console.WriteLine($"Uczniowie, którzy mogą wrócić sami do domu ({dateToCheck.ToShortDateString()}):");
        foreach (var uczen in PodwladniUczniowie)
        {
            if (uczen.CanGoAloneToHome())
                Console.WriteLine($"{uczen.GetFullName()} ({uczen.Szkola})");
        }
    }
}
