namespace day25;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ievadi skaitli!");
            int ievaditaisSkaitlis = Convert.ToInt32(Console.ReadLine());
            if (ievaditaisSkaitlis < 1)
            {
                Console.WriteLine("Error");
            }
            Task.IzvaditSkaitli(ievaditaisSkaitlis);
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Error");
        }

    }
}

