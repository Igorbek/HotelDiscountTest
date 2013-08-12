using System.Collections.Generic;
using System.Linq;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Web.Models
{
    public class SearchResult: ISearchResult
    {
        public IEnumerable<IHotelSearchResult> Hotels { get; private set; }

        public SearchResult(ISearchResult result)
        {
            Hotels = result.Hotels.Select(h => new HotelSearchResult(h)).ToList();
        }
    }
}