using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Group")]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }     
        public virtual ICollection<Programm> Programms { get; set; }
    }
}
