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
            List<Employee> list1 = new List<Employee>();
            String filename = "Untitled.txt";
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

                list1 = JsonSerializer.Deserialize<List<Employee>>(json);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
            return list1;
        }

        public static void SaveFile(String json)
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, "JSON.txt");

            try
            {
                StreamWriter wr = new StreamWriter(fullName, false);
                wr.WriteLine(json);
                wr.Flush();
                wr.Dispose();
                Console.WriteLine("Done");
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
