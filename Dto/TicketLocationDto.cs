using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class TicketLocationDto
    {
        [Key]
        public int TicketLocationId { get; set; }
        public int Title { get; set; }
        public int Content { get; set; }
        public int Address { get; set; }
        public int SDT { get; set; }
        public int Longtitude { get; set; }
        public int Laititude { get; set; }
        public int Image { get; set; }
        public int Arrange { get; set; }
        public int Md5 { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

    }
}
