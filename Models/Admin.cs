using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [MaxLength(50)]
        [Required]
        public string AdminName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Password { get; set; }

        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        [MaxLength(50)]
        [Required]
        public string Phone { get; set; }

        [MaxLength(10)]
        [Required]
        public string Address { get; set; }

        [MaxLength(200)]
        [Required]
        public string Avatar { get; set; }

        [MaxLength(50)]
        [Required]
        public int RoleId { get; set; }

        [MaxLength(50)]
        [Required]
        public DateTime Created_at { get; set; } = DateTime.Now;

        [MaxLength(50)]
        [Required]
        public DateTime Updated_at { get; set; } = DateTime.Now;

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Checkin> Checkins { get; set; }




    }
}
