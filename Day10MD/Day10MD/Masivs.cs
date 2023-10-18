using System;
namespace Day10MD
{
	public class Masivs
	{
		public Masivs()
		{
		}

		public static int[] Md3(List<int> list)
		{
			int garums = list.Count; 
			int[] masivs = new int[garums]; 
			for(int i = 0; i < garums; i++)
			{
				masivs[i] = list[i];  
			}
			return masivs;
			
		}

		public static void Md4(int[] masivs)
		{
			for(int i = 0; i < masivs.Length; i++)
			{
				if (masivs[i] %2 == 0)
				{
					Console.WriteLine(masivs);
				}
				
			}
		}

		public static void Md5(List<String> lists)
		{
			for(int i = 0; i < lists.Count; i++)
			{
				if (lists[i].Length %2 == 0)
				{
					Console.WriteLine(lists);
				}
			}
		}
	}
}

