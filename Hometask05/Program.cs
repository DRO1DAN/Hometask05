using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Book> books = Utils.Deserialize<List<Book>>("D:\\Visual Studio\\С#\\Hometask05\\Hometask05\\jsonFile.json");

        books.ForEach(
            book => Console.WriteLine(
                $"title: {book.Title}\npublisher: {book.PublishingHouse.Name}\npublisher ID: {book.PublishingHouseId}\n"
                )
            );
    }
}