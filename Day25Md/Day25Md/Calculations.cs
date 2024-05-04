using System;
namespace Day25Md
{
	public class Calculations
	{
        public static int Faktorials(int skaitlis)
        {
            int result1 = 1;
            for (int i = 1; i <= skaitlis; i++)//vai ari skaitlis +1
            {
                result1 = result1 * i;
                
            }
            return result1;

        }


        public static int Kapinasana(int skaitlis, int pakape)
        {
            int result2 = 1; ;
            for (int i = 0; i < pakape ; i++)
            {
                result2 = result2 * skaitlis;
            }
            return result2;
        }


    }
}

