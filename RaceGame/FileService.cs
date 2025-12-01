using System.Text;

namespace Race
{
    public class FileService
    {
        public static void Replace(string fileName, string value)
        {
            using var writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(value);
        }

        public static string Read(string fileName)
        {
            using var reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd();
            return value;
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

    }
}
