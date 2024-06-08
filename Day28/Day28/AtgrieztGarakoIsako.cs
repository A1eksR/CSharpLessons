using System;
namespace Day28
{
	public class AtgrieztGarakoIsako
	{
		public int AtgrieztLielako(List<String> list)
		{
			int result = list[0].Length;
			if (list.Count == 0)
			{
				result = -1;
			}
			for(int i = 0; i < list.Count; i++)
			{
				if(result < list[i].Length)
				{
                    result = list[i].Length;
                }
			}
			return result;
		}

		public int AtgrieztMazako(List<String> list)
		{
			int result1 = list[0].Length;
			if(list.Count == 0)
			{
				result1 = -1;
			}
			for(int i = 0; i < list.Count; i++)
			{
				if(result1 > list[i].Length)
				{
					result1 = list[i].Length;
				}
			}
			return result1;
		}
		
	}
}

