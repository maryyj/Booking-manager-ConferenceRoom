using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public int? Seat { get; set; }
        public int? RoomSize { get; set; }
        public bool? TVScreen { get; set; }
        public bool? Whiteboard { get; set; }
        public string? Description { get; set; }
        public ICollection <Booking>? Bookings { get; set; }
    }
}
