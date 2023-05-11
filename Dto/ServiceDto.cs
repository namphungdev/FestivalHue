using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class ServiceDto
    {
        [Key]
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string PathImage { get; set; }
        public int TypeData { get; set; }
        public int SubMenuId { get; set; }
        public string Summary { get; set; }
        public int Longtitude { get; set; }
        public int Latitude { get; set; }
        public string Content { get; set; }

    }
}
