namespace day8MD;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi skaitli!");
        int garums = Garums();
        String[] massivs = new String[garums];
        for(int i = 0; i < garums; i++)
        {
            String input = Console.ReadLine();
            if(input.Length < 5)
            {
                massivs[i] = "aaa";
            }
            else
            {
                massivs[i] = input;
            }
        }

        
    }
    static int Garums()
    {
        int masivaGarums = Convert.ToInt32(Console.ReadLine());
        return masivaGarums;
    }
}

