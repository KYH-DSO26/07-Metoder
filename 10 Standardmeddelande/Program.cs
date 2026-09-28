void loggaMeddelande(string meddelande, string loggTyp = "INFO")
{
    Console.WriteLine($"[{loggTyp.ToUpper()}] - {meddelande}");
}

loggaMeddelande("Något gick fel", "Error");
loggaMeddelande("Allt gick bra");           // Loggtyp får standardvärdet, dvs INFO




Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
