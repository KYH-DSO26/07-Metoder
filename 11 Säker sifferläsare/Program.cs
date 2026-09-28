int LäsHeltal(string ledtext, int min, int max)
{
    while (true)
    {
        Console.Write($"{ledtext} ({min} - {max}): ");
        if (int.TryParse(Console.ReadLine(), out int resultat))
        {
            if (resultat >= min && resultat <= max)
            {
                return resultat;
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Felaktig inmatning. Ange ett tal mellan {min} och {max}.");
        Console.ResetColor();
    }
}

Console.WriteLine($"Längd: {LäsHeltal("Ange båtens längd ", 1, 100)}");



Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
