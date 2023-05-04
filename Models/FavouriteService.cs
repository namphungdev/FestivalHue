using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("FavouriteService")]
    public class FavouriteService
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [Required]
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public virtual User User { get; set; }
        public virtual Service Service { get; set; }

    }
}
