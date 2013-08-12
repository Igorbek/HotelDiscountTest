using System.Collections.Generic;

namespace HotelDiscount.Services.Models
{
    public interface IHotelSearchResult
    {
        IHotel Hotel { get; }
        IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions { get; }
    }
}