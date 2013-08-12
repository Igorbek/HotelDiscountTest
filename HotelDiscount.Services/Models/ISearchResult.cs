using System.Collections.Generic;

namespace HotelDiscount.Services.Models
{
    public interface ISearchResult
    {
        IEnumerable<IHotelSearchResult> Hotels { get; }
    }
}