using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Checkin")]
    public class Checkin
    {
        [Key]
        [Column(Order = 1)]
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }

    }
}
