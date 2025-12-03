
namespace Race
{
    public class RacePlayer
    {      

        public string Name {  get; set; }
        public int Score { get; set; }
        public int Coins { get; set; }
        

        public RacePlayer()
        {
            Name = "Анонимный гонщик";
            Score = 0;
            Coins = 0;
            
        }
    }
}

