using System.Text.Json;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        //ReadFile();
        Connection connection = new Connection();

        Employee em1 = new Employee(1, "Arturs", "Abolins", "Riga", "Latvija");
        employees.Add(em1);

        Console.ReadLine();
    }
    /*public static void ReadFile()
    {
        String filename = "json.txt";
        try
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, filename);

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
    }*/
    
}

