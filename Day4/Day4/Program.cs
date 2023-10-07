namespace Day4;

class Program
{
    static void Main(string[] args)
    {
        Uzd2();
        Console.ReadLine();
    }
    static void Uzd1()
    {
        Console.WriteLine("Ievadi 3 skaitlus");
        double result = 0;
        
        for (int i = 0; i < 3; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            result = result + a;
            
        }
        result = result / 3;
        Console.WriteLine(result);
    }
    static void Uzd2()
    {

    }
    
            
}