using System.Collections.Generic;
using System.Linq;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Web.Models
{
    public class Hotel : IHotel
    {
        public Hotel(IHotel hotel)
        {
            Name = hotel.Name;
            Address = hotel.Address;
            Stars = hotel.Stars;
            Description = hotel.Description;
            ThumbnailImageUri = hotel.ThumbnailImageUri;
            ImagesUris = hotel.ImagesUris.ToList();
        }

        public string Name { get; private set; }
        public string Address { get; private set; }
        public int? Stars { get; private set; }
        public string Description { get; private set; }
        public string ThumbnailImageUri { get; private set; }
        public IEnumerable<string> ImagesUris { get; private set; }
    }
}