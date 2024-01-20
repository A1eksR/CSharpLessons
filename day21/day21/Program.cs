using System.Text.Json;

namespace day21;

class Program
{
    static void Main(string[] args)
    {
        ReadFile();
        Employee em = new Employee(1, "Janis", "Berzins", "Riga", "Latvia");
        String json = JsonSerializer.Serialize(em);

        List<Employee> employees = new List<Employee>();
        employees.Add(em);
        employees.Add(new Employee(2, "Peteris", "Liepa", "Riga", "Latvia"));
        employees.Add(new Employee(3, "Anna", "Ozola", "Riga", "Latvia"));
        employees.Add(new Employee(4, "Liga", "Kaktina", "Riga", "Latvia"));

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        String json2 = JsonSerializer.Serialize(employees, options);
        List<Employee> employees2 = JsonSerializer.Deserialize<List<Employee>>(json2);
        foreach (Employee emp in employees2)
        {
            emp.Print();
        }


        Console.ReadLine();

    }
    public static void ReadFile()
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
    }
}

