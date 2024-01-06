using System;
namespace day20
{
	public class Author
	{
		public int id { get; set; }
		public String vards { get; set; }
		public String uzvards { get; set; }

		public Author(int id, String vards, String uzvards)
		{
			this.id = id;
			this.vards = vards;
			this.uzvards = uzvards;
		}

        public void ShowInfo()
		{
            Console.WriteLine("id: " + id + ", vards: " + vards + ", uzvards: " + uzvards );
            Console.WriteLine("-----------------");
        }
	}
}

