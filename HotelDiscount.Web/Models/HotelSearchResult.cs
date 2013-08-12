using System.Collections.Generic;
using System.Linq;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Web.Models
{
    public class HotelSearchResult : IHotelSearchResult
    {
        public HotelSearchResult(IHotelSearchResult hotelSearchResult)
        {
            Hotel = new Hotel(hotelSearchResult.Hotel);
            PlacementOptions = hotelSearchResult.PlacementOptions.Select(po => new HotelPlacementOptionSearchResult(po)).OrderBy(po => po.Price).ToList();
        }

        public IHotel Hotel { get; private set; }
        public IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions { get; private set; }
    }
}