using System.Text.Json;
using System.Text;

static class Utils
{
    public static List<Book> Deserialize(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File not found: {path}");
            return null;
        }

        try
        {
            string jsonText = File.ReadAllText(path, Encoding.UTF8);
            return JsonSerializer.Deserialize<List<Book>>(jsonText);
        }
        catch
        {
            Console.WriteLine("An error occurred during deserialization.");
            return null;
        }
    }
}