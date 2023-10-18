using System;
namespace Day10MD
{
	public class Skaitli
	{
		public Skaitli()
		{
		}
		public static void Md1(int skaitlis)
		{
			String a = "Para";
			String b = "Nepara";
			if (skaitlis  % 2 == 0)
			{
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine(b);
			}
		}

		public static void Md2(int skaitlis1)
		{
			int result = skaitlis1;
			for(int i = 0; i < 4; i++)
			{
				result = result * skaitlis1;
			}
			Console.WriteLine("resultats ir : " + result);
		}
	}
}

