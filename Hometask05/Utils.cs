using System.Text.Json;

static class Utils
{
    public static T Deserialize<T>(string path)
    {
        string jsonText = File.ReadAllText(path, System.Text.Encoding.UTF8);
        return JsonSerializer.Deserialize<T>(jsonText);
    }
}