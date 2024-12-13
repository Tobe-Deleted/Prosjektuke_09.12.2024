using System.Text.Json;

public class LoadUsers()
{
    public List<UserInfo> LoadUserInfo()
    {
        if (File.Exists("data/randomPeople.json"))
        {
            return JsonSerializer.Deserialize<List<UserInfo>>(File.ReadAllText("data/randomPeople.json"), 
                        new JsonSerializerOptions { WriteIndented=true, PropertyNameCaseInsensitive = true}) 
                        ?? new List<UserInfo>();
        }
        return new List<UserInfo>();
    }
}