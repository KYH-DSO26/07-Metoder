static void HälsaAnvändare(string namn)
{
    Console.WriteLine($"Hej {namn}, hoppas att du har en fantastisk dag på kursen!");
}

Console.Write("Vad heter du? ");
var name = Console.ReadLine();
HälsaAnvändare(name);
Console.WriteLine();
HälsaAnvändare("Annika");
//HälsaAnvändare(3);          // Ger kompileringsfel





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
