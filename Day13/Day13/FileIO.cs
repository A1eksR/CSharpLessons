using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day13_objects
{
    public class FIleIO
    {
        public static void IevaditVertibas()
        {
            try
            {
                String saglabatVertibu = "";
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, "test2.txt");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ievadi vertibu");
                    String ievaditaVertiba = Console.ReadLine();
                    saglabatVertibu = ievaditaVertiba;
                }
                StreamWriter file = new StreamWriter(fullName, false);
                file.WriteLine(saglabatVertibu);
                file.WriteLine(saglabatVertibu);
                file.Flush();
                file.Dispose();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            
            
        }

        public static void ParaditFilu()
        {
            try
            {
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, "test2.txt");
                StreamReader jaunaisFiles = new StreamReader(fullName);
                String line = jaunaisFiles.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = jaunaisFiles.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
        }

        /*public static void ReadFile()
        {
            try
            {
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, "test.txt");

                StreamReader sr = new StreamReader(fullName);
                // //Users//username//Desktop
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
        /*public static void WriteFile()
        {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String fullName = Path.Combine(desktopPath, "test2.txt");

            try
            {
                StreamWriter wr = new StreamWriter(fullName, false);
                wr.WriteLine(ievaditaVertiba);
                wr.WriteLine("bbbb");
                wr.Flush();
                wr.Dispose();
            }
            catch
            {
                Console.WriteLine("Error!");
            }



        }*/
    }
}