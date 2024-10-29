using System.Text;
using static Utils;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Book> books = Deserialize<List<Book>>("D:\\Visual Studio\\С#\\Hometask05\\Hometask05\\jsonFile.json");

        books.ForEach(
            book => Console.WriteLine(
                $"title: {book.Title}\npublisher: {book.PublishingHouse.Name}\npublisher ID: {book.PublishingHouseId}\n"
                )
            );
    }
}