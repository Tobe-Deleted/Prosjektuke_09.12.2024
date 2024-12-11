using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Functions
{
    public void NaughtyList(List<UserInfo> naughtyList)
    {
        Random randomIndex = new Random();

        foreach (UserInfo userinfos in naughtyList)
        {
            int rng = randomIndex.Next(0, 10);
            Console.WriteLine(rng);
            if (rng == 1)
            {
                // Logic..
                userinfos.Punishment = "Gryla!";
                Console.WriteLine($"{userinfos.Name} is eaten by {userinfos.Punishment}");
            }
            else
            {
                // Logic..
                userinfos.Punishment = "Kull!";
                Console.WriteLine($"{userinfos.Name} recieves {userinfos.Punishment}");
            }
        }
    }

    // God kveld, Michael!
}