void GeKlädråd(double temperatur)
{
    if (temperatur < 10)
    {
        Console.WriteLine("Ta på dig en tjock jacka");
    }
    else
    {
        Console.WriteLine("En tröja räcker gott!");
    }
}

GeKlädråd(5);
GeKlädråd(20);




Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
