
int card = Random.Shared.Next(52);
int you = Random.Shared.Next(10);
int bosse = Random.Shared.Next(10);
int bosseHP = 100;
int youHP = 100;
int idk = 0;
int round = 1;


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

bosseHP = bosseHP;
youHP = youHP;

while (youHP > 0 || bosseHP > 0)
{
    Console.WriteLine($"Round {round}:");
    Console.WriteLine("How will you attack your opponent?");
    Console.WriteLine("A. Kick     B. Bonk     C. Bite"); string youM = Console.ReadLine();
    if (youM.ToLower() == "a" || youM.ToLower() == "b" || youM.ToLower() == "c")
    {
        bosseHP = bosseHP - Random.Shared.Next(10);
        youHP = youHP - Random.Shared.Next(10);
        round ++;
        Console.WriteLine($"Your opponent has {bosseHP} HP left!");
        Console.WriteLine($"You have {youHP} HP left!");
    }
    else
    {
        Console.WriteLine("Attack them! Let's redo it, go for the finishing move!");
    }

    if (bosseHP > 0 && youHP <= 0)
    {
        Console.WriteLine($"{name} has gotten ultrakilled!");
    }
    else if (youHP > 0 && bosseHP <= 0)
    {
        Console.WriteLine("Bosse the CP has gotten ultrakilled!");
    }
    else if (youHP <= 0 && bosseHP <= 0)
    {
        Console.WriteLine("Both have gotten ultrakilled!");
    }

    Console.WriteLine("");
}

Console.ReadLine();