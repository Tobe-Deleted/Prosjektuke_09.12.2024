using System.Text.Json;

namespace Prosjektuke_09._12._2024;

class Program
{
    static void Main(string[] args)
    
    {
        LoadUsers LS = new LoadUsers();

    List<UserInfo> humans = LS.LoadUserInfo();
    Console.WriteLine(humans.Count());
    foreach(UserInfo human in humans)
    {
        Console.WriteLine(human.name);
    }
    
    {
        
    }
    }

}
