using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Program")]
    public class Programm
    {
        [Key]
        public int ProgramId { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }


        public string ProgramName { get; set; }

        public string ProgramContent { get; set; }

        public string PathImage { get; set; }

        public int Price { get; set; }

        public int Type_inoff { get; set; }

        public int Type_program { get; set; }

        public int arrange { get; set; }

        [Required]
        public DateTime Fdate { get; set; } = DateTime.Now;
        [Required]
        public DateTime Tdate { get; set; } = DateTime.Now;

        public string Md5 { get; set; }

        public int Total { get; set; }

        /* public virtual ICollection<User> Users { get; set; }*/
        public ICollection<FavouriteProgram> FavouritePrograms { get; set; }




    }
}
