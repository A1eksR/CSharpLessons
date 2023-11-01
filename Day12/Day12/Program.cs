namespace Day12;

class Program
{
    static void Main(string[] args)
    {
        List<int> lists = new List<int>();
        lists.Add(1);
        lists.Add(2);
        lists.Add(3);
        lists.Add(4);
        Tools.MetodeLists(lists);

        int[] masivs = { 6, 7, 8, 9, 10 };
        Tools.MetodeMasivs(masivs);
        Console.ReadLine();
    }

}

