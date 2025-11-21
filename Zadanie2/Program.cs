int number;

do
{
    Console.Write("Podaj liczbę wiekszą od 0: ");
    number = int.Parse(Console.ReadLine());
    if (number == 0 || number < 0)
    {
        Console.WriteLine("Zła liczba, jeszcze raz");
    }
}
while (number == 0 || number < 0);
Console.WriteLine("To poprawna liczba, gratulacje");