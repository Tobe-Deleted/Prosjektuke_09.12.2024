public class Functions()
{
    // God kveld, Michael!
    public void NaughtyList(List<UserInfo> naughtyList)
    {
        Random randomIndex = new Random();

        foreach (UserInfo userinfos in naughtyList)
        {
            if(userinfos.Punishment != null) continue;
            int rng = randomIndex.Next(0, 10);

            if (rng == 1)
            {
                // Logic..
                userinfos.Punishment = "Gryla!";
            }
            else
            {
                // Logic..
                userinfos.Punishment = "coal";
            }
        }

        Console.Clear();
        Console.WriteLine("~~Naughty List~~");
        foreach(UserInfo userinfos in naughtyList)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{userinfos.Name}");
            Console.ResetColor();
            if(userinfos.Punishment == "Gryla!")
            {
                Console.Write(" will be eaten by ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(userinfos.Punishment);
                Console.ResetColor();
            }
            else
            {
                Console.Write(" will receive ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(userinfos.Punishment);
                Console.ResetColor();
            }
        }
    }

    public List<Elf> CreateElves()
    {
        List<Elf> elves = new List<Elf>{};
        string[] gifts = {"Helicopter made from cotton candy", "Living horse made from chocolate", "Aggressive chicken sandwich"};
        string[] gifts2 = {"Lego castle", "Lego dragon", "Lego waterbottle"};
        string[] gifts3 = {"Toy car", "Rubber Ducky", "Unicorn"};
        string[] gifts4 = {"Singing doll that moonwalks", "Twerking Barbie Doll", "Dancing teletubies"};
        string[] gifts5 = {"Vr Headset", "Gaming Pc", "Playstation 5"};
        
        elves.Add(new Elf {Name = "Merry Jingle", Role = "Chief elf", Gift = gifts});
        elves.Add(new Elf {Name = "Lego lost", Role = "Lego Eater", Gift = gifts2});
        elves.Add(new Elf {Name = "Celery Stalkinghood",  Role = "Smelling rubber,", Gift = gifts3});
        elves.Add(new Elf {Name = "Glitterbeard the Beardless", Role = "Twerking around the christmas tree", Gift = gifts4});
        elves.Add(new Elf {Name = "Treehuggus Maximus", Role = "Touching expensive things", Gift = gifts5});

        return elves;
    }

    public void NiceList(List<UserInfo> niceList)
    {
        List<Elf> elves = CreateElves();
        int elfChooser = 0;
        foreach (UserInfo Kid in niceList)
        {
            if(Kid.Elf != null && Kid.Gift != null) continue;
            if(elfChooser == 5) elfChooser = 0;
            Kid.Elf = elves?[elfChooser].Name;
            Random rng = new Random();
            int giftNumber = rng.Next(0, 3);
            Kid.Gift = elves?[elfChooser].Gift?[giftNumber];
            elfChooser++;
        } 
        Console.Clear();
        Console.WriteLine("~~Nice list~~");
        foreach(UserInfo kid in niceList)
        {  
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{kid.Name}");
            Console.ResetColor();
            Console.Write($" will receive ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{kid.Gift}");
            Console.ResetColor();
            Console.Write(" from the elf called ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{kid.Elf}");
            Console.ResetColor();
        }
    }
}
//receives {kid.Gift} from {kid.Elf}