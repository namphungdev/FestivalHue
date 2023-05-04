using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("TicketLocation")]
    public class TicketLocation
    {
        [Key]
        public int TicketLocationId { get; set; }
        [Required]
        public int Title { get; set; }

        [Required]
        public int Content { get; set; }
        [Required]
        public int Address { get; set; }

        [Required]
        public int SDT { get; set; }
        [Required]
        public int Longtitude { get; set; }
        [Required]
        public int Laititude { get; set; }
        [Required]
        public int Image { get; set; }
        [Required]
        public int Arrange { get; set; }
        [Required]
        public int Md5 { get; set; }
        [Required]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [Required]
        public DateTime Updated_at { get; set; } = DateTime.Now;


    }
}
