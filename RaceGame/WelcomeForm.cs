
namespace Race
{
    public partial class WelcomeForm : Form
    {
        public string PlayerName => textBoxPlayerName.Text.Trim();

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {
            var resultsManager = new ResultsManager();
            var topResults = resultsManager.GetTopResults(10);

            if (topResults.Count == 0)
            {
                MessageBox.Show("Пока нет сохраненных результатов!\nСыграйте хотя бы одну игру.",
                              "Таблица результатов",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }

            string resultsText = "🏆 ТОП-10 РЕЗУЛЬТАТОВ 🏆\n\n";
            int position = 1;

            foreach (var result in topResults)
            {
                string medal = position switch
                {
                    1 => "🥇",
                    2 => "🥈",
                    3 => "🥉",
                    _ => $"{position}."
                };

                resultsText += $"{medal} {result.PlayerName}\n";
                resultsText += $"   Очки: {result.Score} | Монеты: {result.Coins}\n";
                resultsText += $"   Дата: {result.Date:dd.MM.yyyy HH:mm}\n\n";
                position++;
            }

            MessageBox.Show(resultsText, "Таблица результатов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}