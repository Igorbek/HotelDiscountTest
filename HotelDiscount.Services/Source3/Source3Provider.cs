using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Services.Source3
{
    public static class Source3Provider
    {
        public static ISearchProvider GetSearchProvider(HttpMessageHandler httpMessageHandler = null)
        {
            return new Source3SearchProvider(httpMessageHandler);
        }

        internal static readonly Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(() => new XmlSerializer(typeof(HotelValuedAvailRS)), true);
        public const string SeriveUri = "http://rs.hoteldiscount.ru/tsrc.aspx?p=3";
    }

    internal class Source3SearchProvider : ISearchProvider
    {
        private readonly HttpMessageHandler _httpMessageHandler;

        public Source3SearchProvider(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
        }

        public async Task<ISearchResult> SearchAsync(SearchOptions options)
        {
            var client = _httpMessageHandler == null ? new HttpClient() : new HttpClient(_httpMessageHandler);
            var stream = await client.GetStreamAsync(Source3Provider.SeriveUri);
            var result = (HotelValuedAvailRS)Source3Provider.Serializer.Value.Deserialize(stream);
            foreach (var hotel in result.ServiceHotel)
                hotel.SearchOptions = options;
            return result;
        }

        public ISearchResult Search(SearchOptions options)
        {
            return SearchAsync(options).Result;
        }
    }

    partial class HotelValuedAvailRS : ISearchResult
    {
        public IEnumerable<IHotelSearchResult> Hotels
        {
            get { return ServiceHotel; }
        }
    }

    partial class HotelValuedAvailRSServiceHotel : IHotelSearchResult
    {
        public IHotel Hotel
        {
            get { return HotelInfo; }
        }

        private List<HotelPlacementOptionSearchResult> _placementOptions;
        internal SearchOptions SearchOptions;

        public IEnumerable<IHotelPlacementOptionSearchResult> MatchRooms(IEnumerable<RoomSearchOption> rooms,
            IEnumerable<HotelValuedAvailRSServiceHotelAvailableRoom> matched)
        {
            if (rooms.Any())
            {
                var r = rooms.First();
                return from m in AvailableRoom
                    where m.HotelOccupancy.Occupancy.AdultCount == r.AdultCount
                          && m.HotelOccupancy.Occupancy.ChildCount == r.ChildCount
                    from mm in MatchRooms(rooms.Except(Enumerable.Repeat(r, 1)), matched.Concat(Enumerable.Repeat(m, 1)))
                    select mm;
            }

            return matched.Select(m => new HotelPlacementOptionSearchResult(matched, this));
        }

        public IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions
        {
            get
            {
                return MatchRooms(SearchOptions.Rooms, Enumerable.Empty<HotelValuedAvailRSServiceHotelAvailableRoom>());
            }
        }
    }

    partial class HotelValuedAvailRSServiceHotelHotelInfo : IHotel
    {
        public string Address
        {
            get { return null; }
        }

        public int? Stars
        {
            get
            {
                if (Category == null || Category.type != "SIMPLE" || Category.shortname.Length < 1)
                    return null;
                var ch = Category.shortname[0];
                if (ch < '1' || ch > '5')
                    return null;
                return ch - '1' + 1;
            }
        }

        public string Description
        {
            get { return null; }
        }

        public string ThumbnailImageUri
        {
            get { return ImagesUris.FirstOrDefault(); }
        }

        public IEnumerable<string> ImagesUris
        {
            get { return ImageList.Select(i=>i.Url); }
        }
    }

    internal class HotelPlacementOptionSearchResult : IHotelPlacementOptionSearchResult
    {
        private readonly IEnumerable<HotelValuedAvailRSServiceHotelAvailableRoom> _availableRooms;
        private readonly HotelValuedAvailRSServiceHotel _serviceHotel;

        public HotelPlacementOptionSearchResult(IEnumerable<HotelValuedAvailRSServiceHotelAvailableRoom> availableRooms, HotelValuedAvailRSServiceHotel serviceHotel)
        {
            _availableRooms = availableRooms;
            _serviceHotel = serviceHotel;
        }

        public string Name
        {
            get { return string.Join(", ", _availableRooms.Select(r => r.HotelRoom.RoomType.Value)); }
        }

        public string Currency
        {
            get { return _serviceHotel.Currency.code; }
        }

        public decimal Price
        {
            get { return _availableRooms.Sum(r => r.HotelRoom.Price.Amount); }
        }

        public IEnumerable<IRoom> Rooms
        {
            get { return null; }
        }

        public IEnumerable<string> Meals
        {
            get { return _availableRooms.Select(r => r.HotelRoom.Board.Value).Distinct(); }
        }
    }
}