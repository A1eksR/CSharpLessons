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

            int lielakais = 0;
            int mazakais = 0;

            if(skaitlis1 > skaitlis2)
            {
                skaitlis1 = lielakais;
            }
            else if(skaitlis2 > skaitlis1)
            {
                skaitlis2 = mazakais;
            }
            else
            {
                Console.WriteLine("Error");
            }

            List<int> list2 = Uzdevums.AtgrieztList(lielakais, mazakais);

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

