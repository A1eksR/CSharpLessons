using System;
namespace Day20Md
{
	public class Book
	{
        public int id { get; set; }
        public String nosaukums { get; set; }
        public int authorId { get; set; }
        public String vards { get; set; }
        public String uzvards { get; set; }

        public Book(int id, String nosaukums, int authorId, String vards, String uzvards)
        {
            this.id = id;
            this.nosaukums = nosaukums;
            this.authorId = authorId;
            this.vards = vards;
            this.uzvards = uzvards;
        }

        public void ShowInfo()
        {
            Console.WriteLine("id: " + id + ", Nosaukums: " + nosaukums + ", AutoraId: " + authorId +", Vards : " + vards + ", Uzvards: " + uzvards);
            Console.WriteLine("-----------------");
        }
    }
}

