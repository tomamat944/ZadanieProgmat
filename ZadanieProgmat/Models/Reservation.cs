using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZadanieProgmat.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;
        public virtual Book Book { get; set; }
        public virtual ApplicationUser ApplicationUser  { get; set; }
    }
}
