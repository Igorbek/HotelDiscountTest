using System.Collections.Generic;

namespace HotelDiscount.Services.Models
{
    public interface IHotelPlacementOptionSearchResult
    {
        string Name { get; }
        string Currency { get; }
        decimal Price { get; }
        IEnumerable<IRoom> Rooms { get; }
        IEnumerable<string> Meals { get; }
    }
}