namespace Day5;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Ievadi 3 vertibas");
        String a = Console.ReadLine();
        String b = Console.ReadLine();
        String c = Console.ReadLine();
        Console.WriteLine(Uzd1(a, b, c));
        Console.ReadLine();*/
        /*Console.WriteLine("Ievadi skaitli");
        int skaitlis = Convert.ToInt32(Console.ReadLine());
        Uzd2(6);
        Console.ReadLine();*/


        Console.WriteLine("Ievadi skaitli");
        int skaitlis = Convert.ToInt32(Console.ReadLine());


    }
    static String Uzd1(String a, String b, String c)
    {
        String result = a + b + c;
        return result;
    }

    static void Uzd2(int skaitlis)
    {
       

        if (skaitlis < 0)
        {
            Console.WriteLine("Kluda");
            return;
        }
        for (int i = 0; i < skaitlis; i++)
        {
            Console.WriteLine("#####");
        }

    }

    static int Uzd3(int skaitlis)
    {
        int result = 0;

        if( skaitlis < 0 || skaitlis == 0)
        {
            Console.WriteLine("Kluda");
            return 0 ;
        }
        for (int i = 1; i <= skaitlis; i++)
        {
            result = result + i;
            
        }
        return result;
    }
}

