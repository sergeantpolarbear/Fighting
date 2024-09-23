int you = Random.Shared.Next(10);
int bosse = Random.Shared.Next(10);
int bosseHP = 100;
int youHP = 100;
int idk = 0;
int round = 1;

Console.WriteLine("Before playing this game, you must sign a waiver that says that you agree to not get mad and not cry if you lose.");
Console.WriteLine("Do you want to proceed? You can either write 'Yes' or 'I agree'.");
if (Console.ReadLine().ToLower() == "yes" || Console.ReadLine().ToLower() == "i agree")
{
    Console.WriteLine("");
    Console.WriteLine("Write your name here:");

    string name = Console.ReadLine();
    Console.WriteLine("");

    while (name.Length < 3)
    {
        Console.WriteLine("Write your name moron!");
        name = Console.ReadLine();
        Console.WriteLine("");
        idk ++;
    }

    Console.WriteLine("");
    if (idk + 1 < 2)
    {
        Console.WriteLine($"Hello {name}");
    }
    else if (idk + 1 > 1 && idk + 1 < 2)
    {
        Console.WriteLine($"I swear to god {name}, can't you write?");
    }
    else if (idk + 1 > 3 && idk + 1 < 4)
    {
        Console.WriteLine($"My brother in jesus, {name}, write your damn name!");
    }
    else if (idk + 1 > 5)
    {
        Console.WriteLine($"Go back to fucking school {name}!");
    }

    Console.WriteLine("");
    Console.WriteLine($"It took {idk + 1} times, {idk} too many");

    Console.WriteLine("");
    Console.WriteLine("You'll face the infomous 'Bosse the CP', a KD of 104:0, good luck!");

    Console.WriteLine("How much money do you want to bet?");
    string m = Console.ReadLine();
    int money = 0;
    int.TryParse(m, out money);
    Console.WriteLine("");

    Console.WriteLine("You both start with 100HP each, are you ready?");
    if (Console.ReadLine().ToLower() == "yes")
    {
        Console.WriteLine("");
        while (youHP > 0 && bosseHP > 0)
        {
            Console.WriteLine($"Round {round}:");
            Console.WriteLine("How will you attack your opponent?");
            Console.WriteLine("A. Kick     B. Bonk     C. Bite"); string youM = Console.ReadLine();

            if (youM.ToLower() == "a" || youM.ToLower() == "b" || youM.ToLower() == "c")
            {
                Console.WriteLine("");
                bosseHP = bosseHP - Random.Shared.Next(10);
                youHP = youHP - Random.Shared.Next(10);
                round ++;

                if (bosseHP < 0)
                {
                    Console.WriteLine($"Your opponent has 0HP left!");
                }
                else
                {
                    Console.WriteLine($"Your opponent has {bosseHP}HP left!");
                }

                if (youHP < 0)
                {
                    Console.WriteLine($"You have 0HP left!");
                }
                else
                {
                    Console.WriteLine($"You have {youHP}HP left!");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Attack them! Let's redo it, go for the finishing move!");
            }

            if (bosseHP > 0 && youHP <= 0)
            {
                money -= 100;
                Console.WriteLine($"{name} has gotten ultrakilled!");
                Console.WriteLine($"{name} has gotten skill issued!");
                Console.WriteLine($"{name} has ${100 - money} left.");
            }
            else if (youHP > 0 && bosseHP <= 0)
                {
                Console.WriteLine("Bosse the CP has gotten ultrakilled!");
                Console.WriteLine("Bosse the CP has gotten skill issued!");
                Console.WriteLine($"{name} has ${100 + money} left.");
            }
            else if (youHP <= 0 && bosseHP <= 0)
            {
                Console.WriteLine("Both have gotten ultrakilled!");
                Console.WriteLine("Both have gotten skill issued!");
            }
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Oh well you're no fun");
    }
}

Console.ReadLine();