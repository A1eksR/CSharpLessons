namespace MdDay4;

class Program
{
    static void Main(string[] args)
    {
        MD4();
        Console.ReadLine();
    }
    static void MD1()
    {
        Console.WriteLine("Ievadi simbolu virkni!");
        int KopejaisGarums = 0;
        for (int i = 0; i < 5; i++)
        {
            int virkne = Convert.ToInt32(Console.ReadLine());
            KopejaisGarums = KopejaisGarums + virkne;
        }
        Console.WriteLine(KopejaisGarums);
    }
    static void MD2()
    {
        for (int i = 5; i < 55; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void MD3()//Nestrada
    {
        Console.WriteLine("Ievadi cik skaitlus cik gribi");
        int summa = 0;
        int Skaitlis = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < Skaitlis; i++)
        {
            summa = summa + Skaitlis;
        }
        Console.WriteLine(summa);
    }
    static void MD4()
    {
        Random a = new Random();
        for (int i = 0; i < 3; i++)
        {
            int skaitlis = a.Next(1, int.MaxValue);
            Console.WriteLine(skaitlis);
        }
    }
}

