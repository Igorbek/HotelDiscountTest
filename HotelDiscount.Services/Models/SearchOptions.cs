using System;
using System.Collections.Generic;

namespace HotelDiscount.Services.Models
{
    public struct SearchOptions
    {
        public string City { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public IEnumerable<RoomSearchOption> Rooms { get; set; }
    }

    public struct RoomSearchOption
    {
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
    }
}