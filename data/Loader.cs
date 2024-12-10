using System.Text.Json;

public class LoadUsers()
{
    public List<UserInfo> LoadUserInfo()
    {
        if (File.Exists("data/randomPeople.json"))
        {
            return JsonSerializer.Deserialize<List<UserInfo>>(File.ReadAllText("data/randomPeople.json"), new JsonSerializerOptions { WriteIndented=true}) ?? new List<UserInfo>();
        }
            Console.WriteLine("outsideif");
        return new List<UserInfo>();
    }
}