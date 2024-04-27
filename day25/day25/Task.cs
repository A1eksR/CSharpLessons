using System;
namespace day25
{ 
    public class Task
	{
        public static void IzvaditSkaitli(int ievaditaisSkaitlis)
        {
            String simblos = "$";
            String rezultats = " ";
            for (int i = 0; i < ievaditaisSkaitlis; i++)
            {
                rezultats = rezultats + simblos;
                Console.WriteLine(rezultats);
            }
            
        }
    }
}

