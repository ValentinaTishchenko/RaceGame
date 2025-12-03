namespace Race
{
    public partial class resultsForm : Form
    {
        private List<GameResult> results;
        public resultsForm(List<GameResult> gameResults)
        {
            InitializeComponent();
            this.results = gameResults ?? new List<GameResult>();
            LoadResultsToGrid();
        }

        private void LoadResultsToGrid()
        {
            dataGridView1.Rows.Clear();
            if (results == null || results.Count == 0)
            {
                dataGridView1.Rows.Add("", "Нет результатов", "", "");
                return;
            }

            var maxToShow = GameConstants.MaxResultsCount;
            var displayCount = Math.Min(maxToShow, results.Count);

            for (var i = 0; i < displayCount; i++)
            {
                var result = results[i];
                var player = result.Player;

                dataGridView1.Rows.Add
                (                    
                    result.Date.ToString("dd.MM.yyyy HH:mm"),
                    player.Name,
                    player.Score.ToString("N0"),
                    player.Coins.ToString("N0")
                );

            }
        }
    }
}
