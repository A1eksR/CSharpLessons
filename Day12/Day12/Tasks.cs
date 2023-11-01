using System;
namespace Day12
{
	public class Tasks
	{
		public Tasks()
		{
		}

		public static void MetodeKlaseTasks(int[] masivs)
		{
			List<int> lists = new List<int>();
			for (int i = masivs.Length - 1; i >= 0; i--)
			{
				lists.Add(masivs[i]);
			}
			Console.WriteLine(lists);
		}


	}

}

