namespace Day12;

class Program
{
    static void Main(string[] args)
    {
        /*List<int> lists = new List<int>();
        lists.Add(1);
        lists.Add(2);
        lists.Add(3);
        lists.Add(4);
        Tools.MetodeLists(lists);

        int[] masivs = { 6, 7, 8, 9, 10 };
        Tools.MetodeMasivs(masivs);
        Console.ReadLine();*/

        Pet pet1 = new Pet("Janis, ", " Papagailis", 9);
        pet1.IzvaditInfo();

        Pet pet2 = new Pet("Alberts, ", " Lauva", 13);
        pet2.IzvaditInfo();

        Pet pet3 = new Pet("Andrejs, ", " Begimots", 15);
        pet1.IzvaditInfo();

        List<String> petLists = new List<String>();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ievadi Majdzivnieku!");
            String petIevade = Console.ReadLine();
            petLists.Add(petIevade);
        }
       

    }

}

