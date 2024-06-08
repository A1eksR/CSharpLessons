using System;
namespace Day28
{
	public class AtgrieztGarakoIsako
	{
		public int AtgrieztLielako(List<String> list)
		{
			int result = 0;
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
			int result1 = 0;
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

		public int AtgrieztLielakoPositivo(List<int> list)
		{
			int result2 = int.MinValue;
			for(int i = 0; i < list.Count; i++)
			{
				if(result2 < list[i] || list[i] > 0)
				{
					result2 = list[i];
				}
			}
			return result2;
		}
		
	}
}

