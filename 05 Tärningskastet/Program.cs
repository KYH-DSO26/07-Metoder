int KastaTärning()
{
    var rnd = new Random();
    return rnd.Next(1, 7);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Tärningskast nummer {i} ger: {KastaTärning()}");
}





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
