using System.Collections.Generic;
using System.Linq;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Web.Models
{
    public class HotelPlacementOptionSearchResult : IHotelPlacementOptionSearchResult
    {
        public HotelPlacementOptionSearchResult(IHotelPlacementOptionSearchResult hotelPlacementOptionSearchResult)
        {
            Name = hotelPlacementOptionSearchResult.Name;
            Currency = hotelPlacementOptionSearchResult.Currency;
            Price = hotelPlacementOptionSearchResult.Price;
            Rooms = Rooms == null ? null : hotelPlacementOptionSearchResult.Rooms.Select(r => new Room(r)).ToList();
            Meals = hotelPlacementOptionSearchResult.Meals.ToList();
        }

        public string Name { get; private set; }
        public string Currency { get; private set; }
        public decimal Price { get; private set; }
        public IEnumerable<IRoom> Rooms { get; private set; }
        public IEnumerable<string> Meals { get; private set; }
    }
}