namespace Labb_1_Avancerat.NET.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
