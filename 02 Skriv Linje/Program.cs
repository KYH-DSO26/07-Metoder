static void SkrivAvskiljare()
{
    //Console.WriteLine("******************************");
    Console.WriteLine(new string('*', 30));
}

Console.WriteLine("En första rad med text");
SkrivAvskiljare();
Console.WriteLine("Här kommer andra raden med text");
SkrivAvskiljare();
Console.WriteLine("Här är tredje och sista raden. Nu orkar vi inte mer");
SkrivAvskiljare();



Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
