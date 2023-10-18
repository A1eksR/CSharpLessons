using System;
namespace Day11
{
	public class Students
	{
		public static String vards = "Arturs";
		public static String uzvards = "Abolins";

		private static List<int> atzimes = new List<int>();

		public static void SkolenaAtzimes(int JaunaAtzime1, int JaunaAtzime2, int JaunaAtzime3 )
		{
			atzimes.Add(JaunaAtzime1);
            atzimes.Add(JaunaAtzime2);
            atzimes.Add(JaunaAtzime3);
        }

        public static void StudentaInfo()
        {
            
            Console.WriteLine("Studenta vards un uzvards ir : " + vards + uzvards);
			Console.WriteLine("Studenta videja atzime ir : " + VidejaAtzime(atzimes));
            
        }

        public static double VidejaAtzime(List<int> atzimes)
		{
			double result = 0;
			for(int i = 0; i < atzimes.Count; i++)
			{
				result = result + atzimes[i];

			}
			result = result / atzimes.Count;
			return result; 
		}
        
    }
}

