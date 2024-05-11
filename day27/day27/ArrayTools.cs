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
                    result = i;
                    

                }
               
                

            }
            return result;
            
        }

        public List<int> Uzd2(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 != 0)
                {
                    arr[i] = 0;
                }
                list.Add(arr[i]);
            }
            return list;
            
        }
    }
}

