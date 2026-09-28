string FastställBetyg(int poäng)
{
    if (poäng < 0 || poäng > 100) return "Ogiltig poäng";
    if (poäng >= 80) return "VG";
    if (poäng >= 50) return "G";
    return "IG";
}

Console.WriteLine($"Poäng: 98 ger betyg {FastställBetyg(98)}");
Console.WriteLine($"Poäng: 75 ger betyg {FastställBetyg(75)}");
Console.WriteLine($"Poäng: 36 ger betyg {FastställBetyg(36)}");
Console.WriteLine($"Poäng: -36 ger betyg {FastställBetyg(-36)}");
Console.WriteLine($"Poäng: 136 ger betyg {FastställBetyg(136)}");





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
