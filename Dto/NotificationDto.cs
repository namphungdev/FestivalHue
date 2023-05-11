using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class NotificationDto
    {
        public int UserId { get; set; }
        public int ProgramId { get; set; }
        public int ProgramName { get; set; }
        public DateTime FDate { get; set; }

    }
}
