namespace MDDay6;

class Program
{
    static void Main(string[] args)
    {
        Md4();
        Console.ReadLine();
    }
    static void Md1()
    {
        Console.WriteLine("Ievadi 5 ciparus");
        int skaitlis = 0;
        for (int i = 0; i < 5; i++)
        {
            skaitlis = Convert.ToInt32(Console.ReadLine());
            if (skaitlis % 2 == 0)
            {
                Console.WriteLine(skaitlis);
            }
            else
            {

            }
        }
        
    }
    static void Md2()
    {
        Console.WriteLine("Ievadi 5 skaitlus!");
        int neparaSkaitlis = 0;
        for(int i = 0; i < 5; i++)
        {
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            if (skaitlis % 2 != 0)
            {
                neparaSkaitlis++;
            }
        }
        Console.WriteLine("Ir " + neparaSkaitlis + " nepara skaitli!");
    }
    static void Md3()
    {
        Console.WriteLine("Ievadi cik ciparus gribi!");
        int skaitlis = Convert.ToInt32(Console.ReadLine());
        int ParaSkaitlis = 0;
        int NeparaSkaitlis = 0;
        for (int i = 0; i < skaitlis; i++)
        { 
            if (skaitlis % 2 == 0)
            {
                ParaSkaitlis++;
            }
            if (skaitlis % 2 != 0)
            {
                NeparaSkaitlis++;
            }
        }
        Console.WriteLine("Ir " + ParaSkaitlis + " para skaitli");
        Console.WriteLine("Ir " + NeparaSkaitlis + " nepara skaitli");

    }
    static void Md4()
    {
        Console.WriteLine("Ievadi 10 ciparus!");
        int skaitlusumma = 0;
        for(int i = 0; i < 10; i++)
        {
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            if(skaitlis % 2 != 0)
            {
                Console.WriteLine("Ievadits nepara skaitlis");
                return;
            }
            skaitlusumma = skaitlusumma + skaitlis;
        }
        Console.WriteLine("Skaitlu summa ir " + skaitlusumma);
    }
}

