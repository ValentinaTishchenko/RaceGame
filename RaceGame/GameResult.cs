
namespace Race
{
    public class GameResult
    {
        public string PlayerName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int Coins { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
