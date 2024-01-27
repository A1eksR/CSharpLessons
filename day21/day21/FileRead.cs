using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day21
{
    public class FileRead
    {
        public static List<Employee> ReadFile()
        {
            List<Employee> list = new List<Employee>();
            String filename = "data.json";
            try
            {
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, filename);

                StreamReader sr = new StreamReader(fullName);

                
                String line = sr.ReadLine();
                String json = "";

                while (line != null)
                {
                    json = json + line;
                    line = sr.ReadLine();
                }

                list = JsonSerializer.Deserialize<List<Employee>>(json);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
            return list;
        }
    }
}
