using System.ComponentModel.DataAnnotations;

namespace ZadanieProgmat.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
