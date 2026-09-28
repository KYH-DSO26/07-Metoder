/*
 * E-ostvalidering kan göras mer uttömmande. Googla på "validera epostadress i C# med regex"
 */


bool ÄrGiltigEpost(string epost)
{
    var ärGiltig = epost.Contains('@') && epost.Contains(".") && epost.Length >= 5;
    return ärGiltig;
}
void KollaEpost(string epost)
{
    Console.WriteLine($"{epost} är giltig: {ÄrGiltigEpost(epost)}");
}

var epost = "claes@gmail.com";
KollaEpost(epost);

epost = "";
KollaEpost(epost);

epost = "xxxxx@";
KollaEpost(epost);


Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
