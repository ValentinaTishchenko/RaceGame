
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

        public RacePlayer(string name) : this()
        {
            Name = name;
        }

        public RacePlayer(string name, int score, int coins, int carSpeed)
        {
            Name = name;
            Score = score;
            Coins = coins;
            CarSpeed = carSpeed;
        }

        public void Reset()
        {
            Score = 0;
            Coins = 0;
            CarSpeed = GameConstants.InitialCarSpeed;
        }

        public void AddCoin()
        {
            Coins++;
        }

        public void SpendCoins(int amount)
        {
            if (Coins >= amount)
            {
                Coins -= amount;
            }
        }

        public bool CanContinue()
        {
            return Coins >= GameConstants.CoinsForContinue;
        }

        public void IncreaseSpeed()
        {
            if (CarSpeed < GameConstants.MaxCarSpeed)
                CarSpeed++;
        }

        public void DecreaseSpeed()
        {
            if (CarSpeed > 0)
                CarSpeed--;
        }

    }
}

