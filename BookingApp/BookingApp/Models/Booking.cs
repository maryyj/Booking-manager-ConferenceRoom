using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int? Week { get; set; }
        public int? Day { get; set; }
        public string? Name { get; set; }
        public string? WorkTitle { get; set; }
        public int? RoomId { get; set; }
        public bool? IsAvailable { get; set; }
        public virtual Room? Room { get; set; }

    }
}
