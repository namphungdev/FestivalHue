using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int TicketTypeId { get; set; }
        public virtual TicketType TicketType { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }




    }
}
