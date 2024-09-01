﻿using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class Feedback : BaseModel
    {
        [Range(1,5)]
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}
