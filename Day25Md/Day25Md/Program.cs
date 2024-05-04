namespace Day25Md;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ievadi skaitli!");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            int faktorials = Calculations.Faktorials(skaitlis);
            int kapinasana = Calculations.Kapinasana(skaitlis);
            Console.WriteLine("Faktorials: " + faktorials + " Kapinasana: " + kapinasana);
            
        }
        catch
        {
            Console.WriteLine("Error");
        }
        Console.ReadLine();

        
        
    }
}

