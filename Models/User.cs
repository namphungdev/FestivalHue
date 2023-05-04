using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [MaxLength(10)]
        [Required]
        public string Phone { get; set; }
        [MaxLength(50)]
        [Required]
        public string Address { get; set; }
        [MaxLength(50)]
        [Required]

        public string CMND { get; set; }
        [MaxLength(200)]
        [Required]

        public string Avatar { get; set; }
        [MaxLength(50)]
        [Required]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [MaxLength(50)]
        [Required]
        public DateTime Updated_at { get; set; } = DateTime.Now;
        [MaxLength(50)]
        [Required]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Program> Programs { get; set; }

    }
}
