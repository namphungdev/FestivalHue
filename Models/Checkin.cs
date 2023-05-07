using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Checkin")]
    public class Checkin
    {
        
        public int AdminId { get; set; }
        
        public int TicketId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool Status { get; set; }
        
        public Ticket Ticket { get; set; }
        
        public Admin Admin { get; set; }
    }
}
