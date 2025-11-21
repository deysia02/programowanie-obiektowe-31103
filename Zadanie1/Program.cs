string password = "admin123";
string input = "";

Console.WriteLine("Podaj hasło:");

while (input != password)
{
    input = Console.ReadLine();
    if (input != password)
    {
        Console.WriteLine("Złe hasło, spróbuj ponownie");
    }    else
    {
        Console.WriteLine("Hasło poprawne, możesz wejśc");
    }
}