using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("Notification")]
    public class Notification
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }

        public int ProgramName { get; set; }
        public DateTime FDate { get; set; }


    }
}
