namespace Day14;

class Program
{
    static void Main(string[] args)
    {
        IeliktSkaitlus();


    }

    static void IeliktSkaitlus()
    {
        String filename = "data.txt";
        try
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, filename);
            StreamWriter file = new StreamWriter(fullName, true);

            for (int i = 0; i < 10; i++)
            {
                int skaitli = Convert.ToInt32(Console.ReadLine());
                file.WriteLine(skaitli);
            }
            file.Flush();
            file.Dispose();
        }
        catch
        {
            Console.WriteLine("Error");
        }
        OpenFile("a");
    }

    static void OpenFile(String filename)
    {
        try
        {
            Console.WriteLine("Vai gribi atvert mapi ? Ja/Ne");
            String atbilde = Console.ReadLine();

            if (atbilde == "Ja")
            {
                List<int> lists = new List<int>();

                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, filename);

                StreamReader sr = new StreamReader(fullName);

                String line = sr.ReadLine();

                while (line != null)
                {
                    lists.Add(Convert.ToInt32(line));
                    line = sr.ReadLine();
                }
                PutInFile(lists);
            }
            else if (atbilde == "No")
            {
                return;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error!");
            Console.WriteLine(ex.Message);
        }
    }

    static void PutInFile(List<int> lists)
    {
        for(int i = 0; i < lists.Count; i++)
        {
            Console.Write(lists[i] + " ; ");
        }
        Console.WriteLine();
        Izvele();
    }

    static void Izvele()
    {
        try
        {

            Console.WriteLine("Vai gribi ievadit 10 jaunus skaitlus un vecos dzest ?");
            String izvele = Console.ReadLine();

            if (izvele == "Ja")
            {
                IeliktSkaitlus();
            }
            else if (izvele == "Ne")
            {
                return;
            }
        }
        catch
        {
            Console.WriteLine("Error");
        }
    }
}

