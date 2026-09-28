void DelaFullständigtNamn(string fulltNamn, out string förnamn, out string efternamn)
{
    string[] delar = fulltNamn.Split(' ');
    if (delar.Length >= 2)
    {
        förnamn = delar[0];
        efternamn = delar[delar.Length - 1];
    }
    else
    {
        förnamn = fulltNamn;
        efternamn = "Ej angivet";
    }
}

string förnamn, efternamn;

DelaFullständigtNamn("Claes Engelin", out  förnamn, out  efternamn);
Console.WriteLine($"{förnamn} {efternamn}");    // Claes Engelin

DelaFullständigtNamn("Claes", out  förnamn, out  efternamn);
Console.WriteLine($"{förnamn} {efternamn}");    // Claes Ej angivet

DelaFullständigtNamn("Elisabeth Tand Ringqvist", out  förnamn, out  efternamn);
Console.WriteLine($"{förnamn} {efternamn}");    // Ellisabeth Ringqvist







Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
