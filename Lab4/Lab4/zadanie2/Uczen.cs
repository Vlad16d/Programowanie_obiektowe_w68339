using System;

public class Uczen : Osoba
{
    public string Szkola { get; set; }
    public bool MozeSamWracacDoDomu { get; set; }

    public void SetSchool(string szkola) => Szkola = szkola;

    public void ChangeSchool(string nowaSzkola)
    {
        Console.WriteLine($"{GetFullName()} zmienia szkołę z {Szkola} na {nowaSzkola}");
        Szkola = nowaSzkola;
    }

    public void SetCanGoHomeAlone(bool canGo) => MozeSamWracacDoDomu = canGo;

    public override string GetEducationInfo() => $"Uczeń w szkole: {Szkola}";

    public override bool CanGoAloneToHome()
    {
        if (GetAge() < 12 && !MozeSamWracacDoDomu)
        {
            Console.WriteLine($"{GetFullName()} nie może sam wracać do domu (zbyt młody).");
            return false;
        }

        return true;
    }
}
