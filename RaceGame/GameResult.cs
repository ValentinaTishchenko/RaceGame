namespace Race
{
    public class GameResult
    {
        public GameResult() {}
        public RacePlayer Player { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;         
      
    }
}
