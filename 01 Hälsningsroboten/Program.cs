int a = 5;
static void VisaHälsning()
{
    int a = 1;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Välkommen till systemet! Robotaktiverad");
    Console.WriteLine($"a = {a}");
    Console.ResetColor();
}

VisaHälsning();

Console.WriteLine($"a = {a}");


Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();