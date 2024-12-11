public class Functions2()
{
    public List<Elves> CreateElves()
    {
        List<Elves> elves = new List<Elves>{};
        string[] gifts = {"Helicopter made from cotton candy", "Living horse made from chocolate", "Aggressive chicken sandwich"};
        string[] gifts2 = {"Lego castle", "Lego dragon", "Lego waterbottle"};
        string[] gifts3 = {"Toy car", "Rubber Ducky", "Unicorn"};
        string[] gifts4 = {"Singing doll that moonwalks", "Twerking Barbie Doll", "Dancing teletubies"};
        string[] gifts5 = {"Vr Headset", "Gaming Pc", "Playstation 5"};
        
        elves.Add(new Elves {Name = "Merry Jingle", Role = "Chief elf", Gift = gifts});
        elves.Add(new Elves {Name = "Lego lost", Role = "Lego Eater", Gift = gifts2});
        elves.Add(new Elves {Name = "Celery Stalkinghood",  Role = "Smelling rubber,", Gift = gifts3});
        elves.Add(new Elves {Name = "Glitterbeard the Beardless", Role = "Twerking around the christmas tree", Gift = gifts4});
        elves.Add(new Elves {Name = "Treehuggus Maximus", Role = "Touching expensive things", Gift = gifts5});

    }

    public void Nicelist(List<UserInfo> niceList)
    {
        
    }
}
