
namespace Race
{
    public class RacePlayer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
              name = value;
            }
        }

        public int Score { get; set; }
        public int Coins { get; set; }
        public int CarSpeed { get; set; }

        public RacePlayer()
        {
            Name = "Анонимный гонщик";
            Score = 0;
            Coins = 0;
            CarSpeed = GameConstants.InitialCarSpeed;
        }

    }
}

