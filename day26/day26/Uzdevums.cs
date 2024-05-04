using System;
namespace day26
{
	public class Uzdevums
	{
		public static List<int> AtgrieztList(int lielakais, int mazakais)
		{
			List<int> list = new List<int>();
			for(int i = mazakais; i <= lielakais; i++)
			{
				list.Add(i);
			}
			return list;
		}
	}
}

