namespace day25;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        List<int> listReverse = Uzd2(list);
        for(int i = 0; i < listReverse.Count; i++)
        {
            Console.WriteLine(listReverse[i]);
        }
        Console.ReadLine();

    }
    static List<int> Uzd2(List<int> list)
    {
        List<int> listReverse = new List<int>();
        for(int i = 0; i > list.Count; i--)
        {
            listReverse.Add(list[i]);
        }
        return listReverse;
    }


    /*static void Uzd1()
    {
        try
        {
            Console.WriteLine("Ievadi skaitli!");
            int ievaditaisSkaitlis = Convert.ToInt32(Console.ReadLine());
            if (ievaditaisSkaitlis < 1)
            {
                Console.WriteLine("Error");
            }
            Task.IzvaditSkaitli(ievaditaisSkaitlis);
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Error");
        }
    }*/
}

