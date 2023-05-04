using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Group")]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [MaxLength(50)]
        [Required]
        public string GroupName { get; set; }
        [MaxLength(50)]
        [Required]
        public string GroupDescription { get; set; }
    }
}
