using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("FavouriteProgram")]
    public class FavouriteProgram
    {
        public int UserId { get; set; }
        public int ProgramId { get; set; }
        public string Title { get; set; }
        public virtual User User { get; set; }
        public virtual Program Program { get; set; }
    }
}
