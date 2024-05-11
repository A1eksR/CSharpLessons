using System;
namespace day26
{
	public class Uzdevums
	{
		public static List<int> AtgrieztList(int a, int b)
		{

			if (a > b)
			{
				int l = b;
				b = a;
				a = l;
			}

			List<int> list = new List<int>();
			for(int i = a; i <= b; i++)
			{
				list.Add(i);
			}
			return list;
		}
	}
}

