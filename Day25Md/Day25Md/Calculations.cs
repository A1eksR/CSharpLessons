using System;
namespace Day25Md
{
	public class Calculations
	{
        public static int Faktorials(int skaitlis)
        {
            int result1 = 1;
            for (int i = 1; i < skaitlis; i++)
            {
                result1 = result1 * i;
                
            }
            return result1;

        }


        public static int Kapinasana(int skaitlis)
        {
            int result2 = 1; ;
            for (int i = 0; i <= skaitlis - 1; i++)
            {
                result2 = result2 * skaitlis;
            }
            return result2;
        }


    }
}

