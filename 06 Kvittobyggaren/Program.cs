void SkrivUtKvittoRad(string produkt, decimal pris)
{
    Console.WriteLine($"{produkt, -15}{pris, 10:C}");
}

SkrivUtKvittoRad("Kaffe", 75);
SkrivUtKvittoRad("Oxfilé", 237.50m);





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
