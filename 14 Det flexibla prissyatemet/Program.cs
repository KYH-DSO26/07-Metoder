/*
 * Här använder vi params för att kunna skicka in ett varierande antal datapunkter
 */
decimal BeräknaTotalPris(decimal rabattSats, params decimal[] produktPriser)
{
    decimal summa = 0;
    foreach (var pris in produktPriser)
    {
        summa += pris;
    }
    decimal rabatt = summa * rabattSats;
    return summa - rabatt;
}

decimal[] priser2 = { 125.25m, 300m };
decimal[] priser5 = { 125.25m, 300m, 19.75m, 1995m, 26_350.0m };
decimal[] priser0 = { };


var rabatt = 0.15m;

var totalPris = BeräknaTotalPris(rabatt, priser2);
Console.WriteLine($"Totalpris med 2 produkter: {totalPris:C2}");

totalPris = BeräknaTotalPris(rabatt, priser5);
Console.WriteLine($"Totalpris med 5 produkter: {totalPris:C2}");

totalPris = BeräknaTotalPris(rabatt, priser0);
Console.WriteLine($"Totalpris med 0 produkter: {totalPris:C2}");





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
