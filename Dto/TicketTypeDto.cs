using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class TicketTypeDto
    {
        [Key]
        public int TicketTypeId { get; set; }
        public string TicketName { get; set; }
        public string Description { get; set; }

    }
}
