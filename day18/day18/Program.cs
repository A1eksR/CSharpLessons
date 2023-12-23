namespace day18;

class Program
{
    static void Main(string[] args)
    {
        Izveleties();
        Console.ReadLine();
    }

    static void Izveleties()
    {
        Console.WriteLine("ko gribi izvadit : ");
        Console.WriteLine("1- klientu skaitu, ");
        Console.WriteLine("2- garako dziesmu, ");
        Console.WriteLine("3- klientu vardu un uzvardu un dziesmas kuras vini ir nopirkusi. ");
        int izvele = Convert.ToInt32(Console.ReadLine());

        if(izvele == 1)
        {
            Console.WriteLine();
        }
        else if(izvele == 2)
        {
            Console.WriteLine();
        }
        else if(izvele == 3)
        {
            Console.WriteLine();
        }
    }
}

