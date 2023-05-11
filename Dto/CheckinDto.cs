﻿using System.ComponentModel.DataAnnotations;


namespace FestivalHue.Dto
{

    public class CheckinDto
    {    
        public int AdminId { get; set; }    
        public int TicketId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool Status { get; set; }
              
    }
}
