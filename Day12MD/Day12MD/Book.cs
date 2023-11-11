using System;
namespace Day12MD
{
	public class Book
	{
		public String name;
		public String authorName;
		public String authorLastName;
		public int year;
		public int pirmsCikGadiemIzdota;

		public void PirmsCikGadiem(int pirmsCikGadiemIzdota)
		{
			int gramataIzdotaGadi = 2023 - pirmsCikGadiemIzdota;
		}

		public Book(String name, String authorName, String authorLastName, int year, int gramataIzdotaGadi)
		{
			this.name = name;
			this.authorName = authorLastName;
			this.authorLastName = authorLastName;
			this.year = year;
			this.pirmsCikGadiemIzdota = gramataIzdotaGadi;
		}

		public void IzvaditInfo()
		{
			Console.WriteLine("gramatas nosaukums ir : " + name);
			Console.WriteLine("gramatas autora vards ir : " + authorName);
			Console.WriteLine("gramatas autora uzvafrds ir : " + authorLastName);
			Console.WriteLine("gramatas publikacijas gads ir : " + year);
			Console.WriteLine("gramata tika izdota pirms " + pirmsCikGadiemIzdota + " gadiem");
		}
	}
}

