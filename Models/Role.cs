using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(50)]
        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
    }
}
