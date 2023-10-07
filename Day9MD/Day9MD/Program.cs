namespace Day9MD;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi skaitli");
        int garums = Convert.ToInt32(Console.ReadLine());
        int[] a  = Metode1(1);
        Console.WriteLine(Metode1(1));
    }
    static int[] Metode1(int garums)
    {
        int[] masivs = new int[garums];
        for(int i = 0; i < garums; i++)
        {
            Console.WriteLine("Ievadi parametrus");
            masivs[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        return masivs;
    }
}

