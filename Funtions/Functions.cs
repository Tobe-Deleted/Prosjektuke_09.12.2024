using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Functions()
{
    public void NaughtyList(List<UserInfo> NaughtyList)
    {
        Random randomIndex = new Random();

        foreach (UserInfo userinfos in NaughtyList)
        {
            int rng = randomIndex.Next(0, 10);
            if (rng == 1)
            {
                
            }
        }
    }

    // God kveld, Michael!
}

public class UserInfo()
{
    public string Navn { get; set; }
    public string Kull { get; set; }
    public string Gryla { get; set; }
}