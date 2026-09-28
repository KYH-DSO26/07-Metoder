string LäsSäkerText(string ledtext)
{
    while (true)
    {
        Console.Write(ledtext);
        string indata = Console.ReadLine();
        //if (string.IsNullOrWhiteSpace(indata) == false)   // Lite lättare att läsa
        if (!string.IsNullOrWhiteSpace(indata))             // Lätt att missa utropstecknet
        {
            return indata;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Inmatningen får inte vara tom! Försök igen.");
        Console.ResetColor();
    }
}

var indata = LäsSäkerText("Vad heter du? ");
Console.WriteLine($"Goddag {indata}");




Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
