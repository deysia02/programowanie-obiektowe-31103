class Zwierze
{
    public virtual void DajGlos() => Console.WriteLine("Zwierze wydaje dźwięk");
}

class Pies : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Hau hau");
}

class Kot : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Miau");
}

class Program
{
    static void Main()
    {
        Zwierze[] zwierzeta = new Zwierze[]
        {
        new Zwierze(),
        new Pies(),
        new Kot(),
        };

        foreach (Zwierze zwierzatko in zwierzeta)
        {
            zwierzatko.DajGlos();
        }
    }
}
