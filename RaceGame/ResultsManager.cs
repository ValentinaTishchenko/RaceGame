using System.Text.Json;

namespace Race
{
    public class ResultsManager
    {
        private readonly string resultsFilePath;

        public ResultsManager()
        {
            resultsFilePath = Path.Combine(Application.StartupPath, "race_results.json");
        }

        public void SaveResult(GameResult result)
        {
            try
            {
                List<GameResult> allResults = LoadAllResults();
                allResults.Add(result);

                string json = JsonSerializer.Serialize(allResults, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                FileService.Replace(resultsFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении результата: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        public List<GameResult> LoadAllResults()
        {
            try
            {
                if (FileService.FileExists(resultsFilePath))
                {
                    string json = FileService.Read(resultsFilePath);
                    return JsonSerializer.Deserialize<List<GameResult>>(json) ?? new List<GameResult>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке результатов: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }

            return new List<GameResult>();
        }

        public List<GameResult> GetTopResults(int count = 10)
        {
            var allResults = LoadAllResults();
            return allResults
                .OrderByDescending(r => r.Score)
                .ThenByDescending(r => r.Coins)
                .Take(count)
                .ToList();
        }

        public void ClearAllResults()
        {
            try
            {
                FileService.Clear(resultsFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при очистке результатов: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}