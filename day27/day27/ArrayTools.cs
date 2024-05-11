using System;
namespace day27
{
	public class ArrayTools
	{
        public int SearchArray(int a, int[] arr)
        {
            int result = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    result = a;
                    //return result;

                }
               
                

            }
            return result;
            
        }
    }
}

