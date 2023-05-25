﻿using System.ComponentModel.DataAnnotations;

namespace FestivalHue.Dto
{
    public class TicketDto
    {
        [Key]
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int TicketTypeId { get; set; }
        public int ProgramId { get; set; }
        public int UserId { get; set; }
        public DateTime Fdate { get; set; } = DateTime.Now;
    }
}
