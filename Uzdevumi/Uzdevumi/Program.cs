namespace Uzdevumi;

class Program
{
    static void Main(string[] args)
    {
        Calc();
        Console.ReadLine();
    }
    static void Calc()
    {
        Console.WriteLine("Ievadi skaitli!");
        int skaitlis1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ievadi otro skaitli!");
        int skaitlis2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ievadi darbibu : dalisana; reizinasana; saskaitisana vai atnemsana!");
        

        String darbiba = Console.ReadLine();
        int result = 0;
        if (darbiba == "dalisana")
        {
            result = skaitlis1 / skaitlis2;
            Console.WriteLine("resultats ir " + result);
        }
        else if (darbiba == "reizinasana")
        {
            result = skaitlis1 * skaitlis2;
            Console.WriteLine("Resultats ir " + result);
        }
        else if (darbiba == "saskaitisana")
        {
            result = skaitlis1 + skaitlis2;
            Console.WriteLine("Resultats ir " + result);
        }
        else if (darbiba == "atnemsana")
        {
            result = skaitlis1 - skaitlis2;
            Console.WriteLine("Resultats ir " + result);
        }
        else
        {
            Console.WriteLine("Kluda");
            return; 
        }
    }
}

