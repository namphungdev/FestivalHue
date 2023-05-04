using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PathImage { get; set; }
        [Required]
        public int TypeData { get; set; }
        [Required]
        public int SubMenuId { get; set; }

        public virtual ICollection<SubMenu> SubMenus { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public int Longtitude { get; set; }
        [Required]
        public int Latitude { get; set; }
        [Required]
        public string Content { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
