class Osoba
{
    public string Imie;
    public int Wiek;
    public void PrzedstawSie()
    {
        Console.WriteLine($"Jestem {Imie}, mam {Wiek} lat.");
    }
}

class Start
{
    static void Main()
    {
       Osoba osoba1 = new Osoba();
       osoba1.Imie = "Irena";
       osoba1.Wiek = 23;
       osoba1.PrzedstawSie();

       Osoba osoba2 = new Osoba();
       osoba2.Imie = "Jacek";
       osoba2.Wiek = int.Parse("24");
       osoba2.PrzedstawSie();

       Osoba osoba3 = new Osoba();
       osoba3.Imie = "Adam";
       osoba3.Wiek = int.Parse("32");
       osoba3.PrzedstawSie();
    }
}