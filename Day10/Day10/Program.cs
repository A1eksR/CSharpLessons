namespace Day10;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 2, 3 };
        Helper.Uzd2(list);
        Console.ReadLine();
    }










    static List<int> Uzd1(int[] masivs)
    {
        /*int[] masivs = { 1, 2, 3, 4, 5 };
        Console.WriteLine(Uzd1(masivs));
        Console.ReadLine();*/
        List<int> list = new List<int>();

        for(int i = masivs.Length-1; i >= 0; i--)
        {
            list.Add(masivs[i]);
        }
        return list;
    }
}

