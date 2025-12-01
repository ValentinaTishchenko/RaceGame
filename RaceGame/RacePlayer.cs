
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = "Анонимный гонщик";
                    return;
                }

                if (value.Length > GameConstants.MaxPlayerNameLength)
                {
                    name = value.Substring(0, GameConstants.MaxPlayerNameLength);
                    return;
                }

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

