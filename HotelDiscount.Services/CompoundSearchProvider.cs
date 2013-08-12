using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Services
{
    public class CompoundSearchProvider: ISearchProvider
    {
        public List<ISearchProvider> Providers { get; private set; }

        public CompoundSearchProvider()
        {
            Providers = new List<ISearchProvider>();
        }

        public CompoundSearchProvider(IEnumerable<ISearchProvider> providers)
        {
            Providers = providers.ToList();
        }

        public async Task<ISearchResult> SearchAsync(SearchOptions options)
        {
            return new CompundSearchResult(await Task.WhenAll(Providers.Select(p => p.SearchAsync(options))));
        }

        public ISearchResult Search(SearchOptions options)
        {
            return SearchAsync(options).Result;
        }
    }

    internal class CompundSearchResult : ISearchResult
    {
        private readonly IEnumerable<ISearchResult> _searchResults;

        public CompundSearchResult(IEnumerable<ISearchResult> searchResults)
        {
            _searchResults = searchResults;
        }

        public IEnumerable<IHotelSearchResult> Hotels
        {
            get
            {
                return
                    _searchResults.SelectMany(sr => sr.Hotels)
                        .GroupBy(h => h.Hotel.Name)
                        .Select(g => new CompoundedHotelSearchResult(g));
            }
        }
    }

    internal class CompoundedHotelSearchResult : IHotelSearchResult, IHotel
    {
        private readonly IEnumerable<IHotelSearchResult> _searchResults;

        public CompoundedHotelSearchResult(IEnumerable<IHotelSearchResult> searchResults)
        {
            _searchResults = searchResults;
        }

        public IHotel Hotel { get { return this; } }

        public IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions
        {
            get
            {
                return _searchResults.SelectMany(sr => sr.PlacementOptions);
            }
        }

        public string Name
        {
            get { return _searchResults.First().Hotel.Name; }
        }

        public string Address
        {
            get { return _searchResults.Select(sr => sr.Hotel.Address).FirstOrDefault(a => a != null); }
        }

        public int? Stars
        {
            get { return _searchResults.Select(sr=>sr.Hotel.Stars).FirstOrDefault(s=>s.HasValue); }
        }

        public string Description
        {
            get { return _searchResults.Select(sr => sr.Hotel.Description).FirstOrDefault(d => d != null); }
        }

        public string ThumbnailImageUri
        {
            get { return _searchResults.Select(sr => sr.Hotel.ThumbnailImageUri).FirstOrDefault(i => i != null); }
        }

        public IEnumerable<string> ImagesUris
        {
            get
            {
                return
                    _searchResults.Where(sr => sr.Hotel.ImagesUris != null)
                        .SelectMany(sr => sr.Hotel.ImagesUris)
                        .Distinct();
            }
        }
    }
}