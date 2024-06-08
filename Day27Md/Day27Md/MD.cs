using System;
namespace Day27Md
{
	public class MD
	{
		public int AtgrieztGarakaGarumu(List<String> list)
		{
			int result = 0;
			for(int i = 0; i < list.Count; i++)
			{
				if(list == null || i == 0)
				{
					result = -1;
				}

			}
			return result;
		}

		public int AtgrieztIsakaGarumu(List<String> list)
		{
			int result2 = 0;
			for(int i = 0; i < list.Count; i++)
			{
				if(list == null || i == 0)
				{
					result2 = -1;
				}
				
			}
			return result2;
		}
	}
}

