using System;


    static void Main()
    {

        Uczen uczen1 = new Uczen
        {
            Imie = "Jan",
            Nazwisko = "Kowalski",
            Pesel = "12102000123",
            Szkola = "Szkoła Podstawowa nr 1",
            MozeSamWracacDoDomu = true
        };

        Uczen uczen2 = new Uczen
        {
            Imie = "Anna",
            Nazwisko = "Nowak",
            Pesel = "15071004321",
            Szkola = "Szkoła Podstawowa nr 2",
            MozeSamWracacDoDomu = false
        };

        Uczen uczen3 = new Uczen
        {
            Imie = "Piotr",
            Nazwisko = "Wiśniewski",
            Pesel = "11051512345",
            Szkola = "Szkoła Podstawowa nr 3",
            MozeSamWracacDoDomu = true
        };


        Nauczyciel nauczyciel = new Nauczyciel
        {
            Imie = "Maria",
            Nazwisko = "Zielińska",
            Pesel = "75042009876",
            Szkola = "Szkoła Podstawowa nr 1",
            TytulNaukowy = "Magister"
        };


        nauczyciel.AddStudent(uczen1);
        nauczyciel.AddStudent(uczen2);
        nauczyciel.AddStudent(uczen3);

        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
    }

