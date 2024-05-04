namespace day25;

class Program
{
    static void Main(string[] args)
    {
        int rezultats = Uzd3Dala2();
        Console.WriteLine("skaitlis : " + rezultats);
    }

    static void Uzd3Dala1()
    {
        Console.WriteLine("Ievadi skaitli!");
        int skaitlis1 = Convert.ToInt32(Console.ReadLine());


    }
    static int Uzd3Dala2()
    {
        Console.WriteLine("Ievadi skaitli!");
        
        bool nepareizaVertiba = true;
        int rezultats = 0;
        while(nepareizaVertiba)
        {
            try
            {
                int skaitlis2 = Convert.ToInt32(Console.ReadLine());
                
                nepareizaVertiba = false;
                rezultats = skaitlis2;


            }
            catch
            {
                Console.WriteLine("Error");

            }
            
        }
        return rezultats;
        
    }












    /*static List<int> Uzd2(List<int> list)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        List<int> listReverse = Uzd2(list);
        for (int i = 0; i < listReverse.Count; i++)
        {
            Console.WriteLine(listReverse[i]);
        }
        Console.ReadLine();
        //----------------------------------
        List<int> listReverse = new List<int>();
        for(int i = list.Count -1; i > -1; i--)
        {
            listReverse.Add(list[i]);
        }
        return listReverse;
    }*/


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

