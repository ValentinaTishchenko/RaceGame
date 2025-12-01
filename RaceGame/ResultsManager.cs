using System.Text.Json;

namespace Race
{
    public class ResultsManager
    {
        private const string resultsFileName = "race_results.json";

        private static readonly JsonSerializerOptions jsonOptions = new()
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping           
        };

        public void SaveResult(GameResult result)
        {
            var allResults = GetAll();
            allResults.Insert(0, result);

            var topResults = allResults
                .Take(GameConstants.MaxResultsCount)
                .ToList();


            SaveToFile(topResults);
        }

        public List<GameResult> GetAll()
        {
            if (!FileService.FileExists(resultsFileName))
                return new List<GameResult>();

            try
            {
                var json = FileService.Read(resultsFileName);
                return JsonSerializer.Deserialize<List<GameResult>>(json) ?? new List<GameResult>();
            }
            catch
            {
                return new List<GameResult>();
            }
        }

        private void SaveToFile(List<GameResult> results)
        {
            try
            {
                var json = JsonSerializer.Serialize(results, jsonOptions);
                FileService.Replace(resultsFileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка");
            }
        }

        public string GetResultsJson()
        {
            var results = GetAll();
            return JsonSerializer.Serialize(results, jsonOptions);
        }
    }
}