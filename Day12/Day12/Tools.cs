using System;
namespace Day12
{
	public class Tools
	{
		public Tools()
		{
		}


		public static void MetodeLists(List<int> lists)
		{
			for(int i = 0; i < lists.Count; i++)
			{
				Console.Write(lists[i]);
			}
			Console.WriteLine();
		}

		public static void MetodeMasivs(int[] masivs)
		{
			for(int i = 0; i < masivs.Length; i++)
			{
				Console.Write(masivs[i]);
				
			}
			Console.WriteLine();
		}


	}
}

