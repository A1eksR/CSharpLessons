namespace day8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi masiva garumu!");
        int a = Convert.ToInt32(Console.ReadLine());
        double[] b  = new double[a];
        for(int i = 0; i < b.Length; i++)
        {
            b[i] = Convert.ToDouble(Console.ReadLine());
             
        }
        double result = 0;
        for(int i = 0; i < a; i++)
        {
            result = result + b[i];
        }
        result = result / a;
        Console.WriteLine(result);
        Console.ReadLine();

    }







    static String Uzd3(String virkne, int skaitlis)
    {
        /* Console.WriteLine("Ievadi skaitli!");
        int skaitlis = Convert.ToInt32(Console.ReadLine());
        String virkne = "aaa";
        Console.WriteLine(Uzd3(virkne,2));
        Console.ReadLine();*/ //tas bija main
        String result = "";
        if(skaitlis < 2)
        {
            result = "bbb";
        }
        for (int i = 0; i < skaitlis; i++)
        {
            result = result + virkne;
        }
        return result; 
    }


    static double Uzd2(int skaitlis1, double skaitlis2, double result)
    {
        /*Console.WriteLine("Ievadi pirmo skaitli!");
        int skaitlis1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ievadi otro skaitli!");
        double skaitlis2 = Convert.ToDouble(Console.ReadLine());
        double result = 0;

        double metode = Uzd2(1, 2, 3);
        Console.WriteLine(result);
        Console.ReadLine();*/
        for (int i = 0; i < skaitlis1; i++)
        {
            result = result * skaitlis2;
        }
        return result;
    }
    static int Uzd1(int parametrs1, int result)
    {
        /*int parametrs1 = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int metode = Uzd1(1, 2);
        Console.WriteLine(result);*/ //tas bija main metode.
        for (int i = 0; i < parametrs1; i++)
        {
            Console.WriteLine("Ievadi skaitli!");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            result = result + skaitlis2;
        }
        return result;
    }
}

