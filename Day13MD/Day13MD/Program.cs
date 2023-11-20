namespace Day13MD;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<String> lists = new List<String>();
            for(int i =0; i < 5; i++)
            {
                String ievaditSimbolu = Console.ReadLine();
                lists.Add(ievaditSimbolu);
            }
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Error");
        }
    }

    public static void IeliktFila(List<String> lists)
    {
        try
        {

            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, lists);

            StreamWriter file = new StreamWriter(fullName, false);
            for (int i = 0; i < lists.Count; i++)
            {
                file.WriteLine(lists[i]);
            }
            file.Flush();
            file.Dispose();
        }
        catch
        {
            Console.WriteLine("Error");
        }
    }

    public static void LasitFile(StreamWriter file, List<String> lists)
    {
        try
        {

            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, lists);

            StreamReader sr = new StreamReader(fullName);

            String line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error!");
            Console.WriteLine(ex.Message);
        }

    }
}

