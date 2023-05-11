using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class FavouriteProgramDto
    {
        [Key]
        public int UserId { get; set; }
        public int ProgramId { get; set; }
        public string Title { get; set; }
      
    }
}
