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
		//Majasdarbs

		public static void ParliktAtzimesMasiva(int JaunaAtzime1, int JaunaAtzime2, int JaunaAtzime3)
		{
            int[] MasivaAtzimes = new int[2];
			MasivaAtzimes[0] = JaunaAtzime1;
            MasivaAtzimes[1] = JaunaAtzime2;
            MasivaAtzimes[2] = JaunaAtzime3;
			Console.Write(MasivaAtzimes);
			Console.WriteLine();
        }
		

		public static void ParliktAtzimesLista(int JaunaAtzime1, int JaunaAtzime2, int JaunaAtzime3)
		{
			//Nezinaju ka seit var ielikt to masivu, bet tas tapec ka pagajusoreiz nepareizi saku uzd. 
			List<int> ListaAtzimes = new List<int>();
			for(int i = MasivaAtzimes.Length - 1; i >= 0; i--)
			{
				ListaAtzimes.Add(MasivaAtzimes[i]);
			}
		}

		public static void IzdzestAtzimes(int JaunaAtzime1, int JaunaAtzime2, int JaunaAtzime3)
		{
			JaunaAtzime1 = 0;
			JaunaAtzime2 = 0;
			JaunaAtzime3 = 0;
		}
    }
}

