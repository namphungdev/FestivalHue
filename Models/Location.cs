using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Location")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        [MaxLength(50)]
        public string LocationName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LocationAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string LocationImage { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string LocationMap { get; set; }
        [Required]
        [MaxLength(50)]
        public string Summary { get; set; }
        [Required]
        [MaxLength(50)]
        public string Pathimage { get; set; }
        [Required]
        [MaxLength(50)]
        public string longtitude { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lattitude { get; set; }
        [Required]
        [MaxLength(50)]
        public string Typedata { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
    }
}
