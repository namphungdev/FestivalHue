using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class RoleDto
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
