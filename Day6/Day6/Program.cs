namespace Day6;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Ievadi 2 skaitlus!");
        int skaitlis1 = Convert.ToInt32(Console.ReadLine());
        int skaitlis2 = Convert.ToInt32(Console.ReadLine());
        int lielakaisSkaitlis = Uzd1(skaitlis1, skaitlis2);
        Console.WriteLine("Lielakais skaitlis ir " + lielakaisSkaitlis);
        Console.ReadLine();*/


        //Uzdevums 2:
        /*Console.WriteLine("Ievadi 2 skaitlus");
        int cipars = Convert.ToInt32(Console.ReadLine());
        int cipars2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 0;  i< cipars2 + 1;  i++)
        {
            result = result * cipars;
        }

        Console.WriteLine(result);
        Console.ReadLine();*/

        Uzd4();
        Console.ReadLine();

    }
    static int Uzd1(int skaitlis1, int skaitlis2)
    {
        if (skaitlis1 > skaitlis2)
        {
            return skaitlis1;
        }
        else if (skaitlis2 > skaitlis1)
        {
            return skaitlis2;
        }
        return skaitlis2;
    }

    static void Uzd3()
    {
        String input = "";
        int result = 0;
        while (input != "ne")
        {
            Console.WriteLine("Ievadiet skaitli!");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vai velaties turpinat ?");
            input = Console.ReadLine();
            result = result + skaitlis;
        }
        Console.WriteLine(result);

    }
    static void Uzd4()
    {
        String input = "";
        int result = 0;
        while (input != "ne")
        {
            Console.WriteLine("Ievadi skaitli!");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            if (skaitlis > result)
            {
                result = skaitlis;
            }
            else if (skaitlis == result || skaitlis < result)
            {
                result = skaitlis;
            }
            Console.WriteLine("vai velies turpinat ?");
            input = Console.ReadLine();

        }
        Console.WriteLine(result);
    }
}