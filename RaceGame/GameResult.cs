
namespace Race
{
    public class GameResult
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public int Coins { get; set; }
        public DateTime Date { get; set; }

        public GameResult()
        {
            Date = DateTime.Now;
        }

        public GameResult(string playerName, int score, int coins) : this()
        {
            PlayerName = playerName;
            Score = score;
            Coins = coins;
        }
    }
}
