class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) {saldo += kwota;}
    public double PobierzSaldo() {return saldo;}
    public void Wyplata(double kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota}, nowe saldo: {saldo}");
        }
        else
        {
            Console.WriteLine("Nie można wypłacić - niewystarczające saldo");
        }
    }
}

class Start
{
    static void Main()
    {
        KontoBankowe konto = new KontoBankowe();
        konto.Wplata(1000);
        Console.WriteLine($"Saldo po wpłacie: {konto.PobierzSaldo()}");

        konto.Wyplata(500);
        konto.Wyplata(500);
        Console.WriteLine($"Saldo: {konto.PobierzSaldo()}");
        konto.Wyplata(500);
    }
}