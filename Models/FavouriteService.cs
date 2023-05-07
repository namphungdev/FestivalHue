﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FestivalHue.Models
{
    [Table("FavouriteService")]
    public class FavouriteService
    {   
        public int UserId { get; set; }
     
        public int ServiceId { get; set; }
     
        public int Status { get; set; }
    
        public DateTime Created_at { get; set; } = DateTime.Now;
       
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public User User { get; set; }
        public Service Service { get; set; }

    }
}
