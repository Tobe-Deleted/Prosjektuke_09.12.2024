using System.Text.Json;

namespace Prosjektuke_09._12._2024;

class Program
{
    static void Main(string[] args)
    
    {
        LoadUsers LS = new LoadUsers();
        Functions fnc = new Functions();

        Dictionaries dict = new Dictionaries();
        Dictionary<string, int> cars = dict.Cars();
        Dictionary<string, int> music = dict.Music();
        Dictionary<string, int> streetname = dict.Streetnames();
        List<UserInfo> humans = LS.LoadUserInfo();
        List<UserInfo> naughtylist = new List<UserInfo>{};
        List<UserInfo> nicelist = new List<UserInfo>{};
        foreach(UserInfo human in humans)
        {
            int moralityScore = 0;
            moralityScore += cars[human.carModel];
            moralityScore += streetname[human.homeAdress.TrimEnd(new char[]{'1','2','3','4','5','6','7','8','9','0',' '})];
            foreach(string genre in human.musicGenres) 
            {
                moralityScore += music[genre];
            }
            if(human.washesHands) 
            {
                moralityScore += 3;
            }
            else
            {
                moralityScore += -7;
            }
            if(human.donatesToCharity)
            {
                moralityScore += 5;
            }
            else
            {
                moralityScore += -1;
            }
            if(human.toiletPaperOutward)
            {
                moralityScore += 3;
            }
            else
            {
                moralityScore += -2;
            }

            if(moralityScore<1)
            {
                naughtylist.Add(human);
            }
            else
            {
                nicelist.Add(human);
            }


        }

    
    
    
    bool exit = false;
    while (!exit)
    {
        Console.Clear();
            Console.WriteLine("Velg hvilken liste du ønsker");
            Console.WriteLine("1. Nicelist");
            Console.WriteLine("2. Naughtylist");
            Console.WriteLine("0. Avslutt");
            ConsoleKey MainMenuChoice = Console.ReadKey().Key;
            switch (MainMenuChoice)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    fnc.NiceList();
                    Console.ReadKey();

                break;
                case ConsoleKey.D2:
                    Console.Clear();
                    fnc.NaughtyList();
                    Console.ReadKey();
                    break;

                case ConsoleKey.D0:
                    Console.Clear();
                    exit = true;
                    break;

                    
            }
    }
   
    
    
    
    }

}
