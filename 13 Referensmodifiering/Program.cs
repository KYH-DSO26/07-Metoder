static void UppdateraStatus(ref string nuvarandeStatus, bool operationLyckades, string kategori)
{
    if (operationLyckades)
    {
        nuvarandeStatus = "Aktiv och verifierad";
        kategori = "SUCCESS";
    }
    else
    {
        nuvarandeStatus = "Systemfel: Åtgärd krävs";
        kategori = "FAIL";
    }
    Console.WriteLine($"Inne i UppdateraStatus: nuvarandeStatus = '{nuvarandeStatus}', kategori = {kategori}");
}

string status = "Nuvarande status";
String kategori = "INFO";
Console.WriteLine($"Före anrop: status = '{status}', kategori = {kategori}");

UppdateraStatus(ref status, true, kategori);      // OBS! Måste stå ref före status!
Console.WriteLine($"Efter anrop: status = '{status}', kategori = {kategori}");





Console.Write("\n\nTryck på en tangent för att stänga...");
Console.ReadKey();
