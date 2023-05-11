using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class SubMenuDto
    {
        [Key]
        public int SubMenuId { get; set; }
        public string Title { get; set; }
        public string PathIcon { get; set; }
        public int MenuId { get; set; }

    }
}
