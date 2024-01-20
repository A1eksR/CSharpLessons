using System;
namespace TODO
{
	public class Task
	{
		public int id { get; set; }
		public String title { get; set; }
		public String apraksts { get; set; }
		public String statuss { get; set; }

		public Task(int id, String title, String apraksts, String statuss)
		{
			this.id = id;
			this.title = title;
			this.apraksts = apraksts;
			this.statuss = statuss;
		}

		public void ShowInfo()
		{
			Console.WriteLine("id: " + id + "nosaukums: " + title + "apraksts: " + apraksts + "statuss: " + statuss);
			Console.WriteLine("-----------------------");
		}
	}
}

