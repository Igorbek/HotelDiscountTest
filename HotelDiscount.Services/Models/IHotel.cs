using System.Collections.Generic;

namespace HotelDiscount.Services.Models
{
    public interface IHotel
    {
        string Name { get; }
        string Address { get; }
        int? Stars { get; }
        string Description { get; }
        string ThumbnailImageUri { get; }
        IEnumerable<string> ImagesUris { get; }
    }
}