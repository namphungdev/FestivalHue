using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("ProgramType")]
    public class ProgramType
    {
        [Key]
        public int Type_program { get; set; }
        public string ProgramTypeName { get; set; }    
        public virtual ICollection<Programm> Programms { get; set; }
    }
}
