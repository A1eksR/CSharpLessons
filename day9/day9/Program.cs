namespace day9;

class Program
{
    static void Main(string[] args)
    {

        List<int> saraksts = new List<int>();
        saraksts.Add(56);
        saraksts.Add(445);
        saraksts.Add(67);
        Uzd4(saraksts);
        
        Console.ReadLine();
    }
    static void Uzd4(List<int> a)
    {
        for(int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }






















    /*static int //Uzd3()
    {
        /*int uzdevums3 = Uzd3();
        int[] masivs = { uzdevums3 };
        int uzdevums2 = Uzd2(masivs);
        Console.WriteLine("Lielakais skaitlis ir : " + uzdevums2);
        Console.ReadLine();*/

        /*int[] masivs = new int[6];
        Console.WriteLine("Ievadi 6 skaitlus!");
        
        for (int i = 0; i < 6; i++)
        {
            masivs[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        
        //return //masivs;
    }
    static int Uzd2(int[] parametrs)
    {


        int result = int.MinValue;
        for (int i = 0; i < parametrs.Length; i++)
        {
            if (result < parametrs[i])
            {
                result = parametrs[i];
            }
        }
        return result;
    }




    static void Uzd1(int[] parametrs)
    {
        int[] masivs = { 4, 6, 7, 3, 5, 2 };
        //Uzd1(); // pirmas 2 bija maina
        for (int i = 0; i < parametrs.Length; i++)
        {
            if(i % 2 != 0)
            {
                Console.Write(i);
            }
            else
            {

            }
        }
        
    }*/
    
}

