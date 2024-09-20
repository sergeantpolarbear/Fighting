
int card = Random.Shared.Next(52);


Console.WriteLine("Skriv in ditt namn här:");

string name = Console.ReadLine();
while (name.Length < 3)
{
    Console.WriteLine("Skriv in ditt namn för fan din pungråtta");
    name = Console.ReadLine();
}


Console.WriteLine($"Hej {name}");

Console.ReadLine();