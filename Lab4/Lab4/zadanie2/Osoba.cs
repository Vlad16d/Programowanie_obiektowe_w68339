using System;

public abstract class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pesel { get; set; }

    public void SetFirstName(string imie) => Imie = imie;
    public void SetLastName(string nazwisko) => Nazwisko = nazwisko;
    public void SetPesel(string pesel) => Pesel = pesel;

    public string GetFullName() => $"{Imie} {Nazwisko}";

    public int GetAge()
    {
        var yearOfBirth = int.Parse(Pesel.Substring(0, 2));
        var monthOfBirth = int.Parse(Pesel.Substring(2, 2));
        yearOfBirth += (monthOfBirth > 20 ? 2000 : 1900); 
        var birthDate = new DateTime(yearOfBirth, monthOfBirth % 20, int.Parse(Pesel.Substring(4, 2)));
        var age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now < birthDate.AddYears(age)) age--; 
        return age;
    }

    public string GetGender()
    {
        var genderDigit = int.Parse(Pesel.Substring(9, 1));
        return genderDigit % 2 == 0 ? "Kobieta" : "Mężczyzna";
    }

    public abstract string GetEducationInfo();
    public abstract bool CanGoAloneToHome();
}
