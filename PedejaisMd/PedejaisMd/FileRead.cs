using System;
using System.Text.Json;

namespace PedejaisMd
{
	public class FileRead
	{
        public static List<Customer> ReadFile()
        {
            List<Customer> list1 = new List<Customer>();
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

                list1 = JsonSerializer.Deserialize<List<Customer>>(json);
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

