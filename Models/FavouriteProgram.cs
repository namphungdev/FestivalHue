using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("FavouriteProgram")]
    public class FavouriteProgram
    {
        public int UserId { get; set; }
        public int ProgramId { get; set; }
        public string Title { get; set; }
        public  User User { get; set; }
        public  Programm Programm { get; set; }
    }
}
