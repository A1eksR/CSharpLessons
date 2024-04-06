namespace day24;

class Program
{
    static void Main(string[] args)
    {
        WebService webService = new WebService();
        var client = new HttpClient();
        webService.GetPosts(client);
        webService.GetComment(client);
        Console.ReadLine();
    }
}