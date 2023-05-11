using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class GroupDto
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
  
    }
}
