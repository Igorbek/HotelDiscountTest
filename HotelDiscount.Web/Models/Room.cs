using HotelDiscount.Services.Models;

namespace HotelDiscount.Web.Models
{
    public class Room : IRoom
    {
        public Room(IRoom room)
        {
            Type = room.Type;
        }

        public string Type { get; private set; }
    }
}