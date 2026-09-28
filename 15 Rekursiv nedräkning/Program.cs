void RekursivNedräkning(int startVärde)
{
    if (startVärde <= 0) // Basfall
    {
        Console.WriteLine("BOOM!");
        return;
    }
    Console.WriteLine($"T-minus {startVärde}...");
    System.Threading.Thread.Sleep(800);

    RekursivNedräkning(startVärde - 1); // Rekursivt anrop
}

RekursivNedräkning(10);






Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
