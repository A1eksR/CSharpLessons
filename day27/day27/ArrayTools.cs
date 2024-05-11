using System;
namespace day27
{
	public class ArrayTools
	{
        public int SearchArray(int a, int[] arr)
        {
            int result = 0;
            if (a > arr.Length || arr == null)
            {
                result = -1;
            }
            else
            {
                for(int i = arr.Length; i <= a; i++)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}

