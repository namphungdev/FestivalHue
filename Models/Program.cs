using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Program")]
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        public string ProgramName { get; set; }
        [Required]
        public string ProgramContent { get; set; }
        [Required]
        public string PathImage { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Type_inoff { get; set; }
        [Required]
        public int Type_program { get; set; }
        [Required]
        public int arrange { get; set; }

        [Required]
        public DateTime Fdate { get; set; } = DateTime.Now;
        [Required]
        public DateTime Tdate { get; set; } = DateTime.Now;
        [Required]
        public string Md5 { get; set; }
        [Required]
        public int Total { get; set; }

        public virtual ICollection<User> Users { get; set; }



    }
}
