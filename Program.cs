using System.Text.Json;

namespace Prosjektuke_09._12._2024;

class Program
{
    static void Main(string[] args)
    
    {
        LoadUsers LS = new LoadUsers();
        
        Dictionaries dict = new Dictionaries();
        Dictionary<string, int> cars = dict.Cars();
        Dictionary<string, int> music = dict.Music();
        Dictionary<string, int> streetname = dict.Streetnames();
        List<UserInfo> humans = LS.LoadUserInfo();
        foreach(UserInfo human in humans)
        {
            int moralityScore = 0;
            moralityScore += cars[human.carModel];
            moralityScore += streetname[human.homeAdress];
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


            


        }
   
    
    
    
    }

}
