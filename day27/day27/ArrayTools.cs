using System;
namespace day27
{
	public class ArrayTools
	{
        public int SearchArray(int a, int[] arr)
        {
            int result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[a] == a)
                {
                    result = a;
                }
                else
                {
                    result = -1;
                }
            }
            return result;
        }
    }
}

