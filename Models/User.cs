using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        public string Password { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(10)]

        public string Phone { get; set; }
        [MaxLength(50)]
    
        public string Address { get; set; }
        [MaxLength(50)]


        public string CMND { get; set; }
        [MaxLength(200)]


        public string Avatar { get; set; }
        [MaxLength(50)]
        [Required]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [MaxLength(50)]
        [Required]
        public DateTime Updated_at { get; set; } = DateTime.Now;
        /*  [MaxLength(50)]
          [Required]
          public int RoleId { get; set; }
          public virtual Role Role { get; set; }*/

        /*public virtual ICollection<User> Users { get; set; }*/

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<FavouriteProgram> FavouritePrograms { get; set; }
        public virtual ICollection<Checkin> Checkins { get; set; }

    }
}
