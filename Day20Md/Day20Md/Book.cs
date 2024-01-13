using System;
namespace Day20Md
{
	public class Book
	{
        public int id { get; set; }
        public String nosaukums { get; set; }
        public int authorId { get; set; }

        public Book(int id, String vards, String uzvards)
        {
            this.id = id;
            this.nosaukums = nosaukums;
            this.authorId = authorId;
        }

        public void ShowInfo()
        {
            Console.WriteLine("id: " + id + ", Nosaukums: " + nosaukums + ", AutoraId: " + authorId);
            Console.WriteLine("-----------------");
        }
    }
}

