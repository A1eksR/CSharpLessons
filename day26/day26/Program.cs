namespace day26;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ievadi 2 atskirigus skaitlus!");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            List<int> list2 = Uzdevums.AtgrieztList(skaitlis1, skaitlis2);

            for(int i = 0; i< list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
        }
        catch
        {
            Console.WriteLine("Error");
        }
        Console.ReadLine();

        
    }
}

