using System.Collections.Generic;

public class Zamowienie
{
    public int NumerZamowienia { get; set; } 
    public List<string> Produkty { get; set; } 
    public StatusZamowienia Status { get; set; } 

    public Zamowienie(int numerZamowienia, List<string> produkty, StatusZamowienia status)
    {
        NumerZamowienia = numerZamowienia;
        Produkty = produkty;
        Status = status;
    }
}
