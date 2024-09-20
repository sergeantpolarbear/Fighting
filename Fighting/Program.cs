
int card = Random.Shared.Next(52);
int you = Random.Shared.Next(10);
int bosse = Random.Shared.Next(10);
int bosseHP = Random.Shared.Next(100);
int youHP = Random.Shared.Next(100);
int idk = 0;


Console.WriteLine("Skriv in ditt namn här:");

string name = Console.ReadLine();
Console.WriteLine("");

while (name.Length < 3)
{
    Console.WriteLine("Skriv in ditt namn för fan din pungråtta!");
    name = Console.ReadLine();
    Console.WriteLine("");
    idk++;
}

Console.WriteLine("");
if (idk + 1 < 2)
{
    Console.WriteLine($"Hej {name}");
}
else if (idk + 1 > 1 && idk + 1 < 2)
{
    Console.WriteLine($"Hej {name}, kan du inte skriva?");
}
else if (idk + 1 > 3 && idk + 1 < 4)
{
    Console.WriteLine($"Seriöst, {name}, du är inte rolig, skriv ditt jäkla namn!");
}
else if (idk + 1 > 5)
{
    Console.WriteLine($"Asså gå tillbaka till skolan {name}!");
}

Console.WriteLine("");
Console.WriteLine($"Det tog {idk+1} gånger, {idk} för många");

Console.WriteLine("");
Console.WriteLine("Du ska möta Bosse the CP! Han är stark (ouch)");

while (youHP > 0 || bosseHP > 0)
{
    Console.WriteLine("Round 1:");
    Console.WriteLine("Round 1:");
    Console.WriteLine("A. Kick     B. Bonk     C. Bite"); string youM = Console.ReadLine();
    if (youM.ToLower() == "a" || youM.ToLower() == "b" || youM.ToLower() == "c") {bosseHP = bosseHP - you;}
    Console.WriteLine("");
}



Console.ReadLine();