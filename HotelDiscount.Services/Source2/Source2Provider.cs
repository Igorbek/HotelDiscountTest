using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Services.Source2
{
    public static class Source2Provider
    {
        public static ISearchProvider GetSearchProvider(HttpMessageHandler httpMessageHandler = null)
        {
            return new Source2SearchProvider(httpMessageHandler);
        }

        internal static readonly Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(() => new XmlSerializer(typeof(TWS_HotelList)), true);
        public const string SeriveUri = "http://rs.hoteldiscount.ru/tsrc.aspx?p=2";
    }

    internal class Source2SearchProvider : ISearchProvider
    {
        private readonly HttpMessageHandler _httpMessageHandler;

        public Source2SearchProvider(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
        }

        public async Task<ISearchResult> SearchAsync(SearchOptions options)
        {
            var client = _httpMessageHandler == null ? new HttpClient() : new HttpClient(_httpMessageHandler);
            var stream = await client.GetStreamAsync(Source2Provider.SeriveUri);
            return (TWS_HotelList)Source2Provider.Serializer.Value.Deserialize(stream);
        }

        public ISearchResult Search(SearchOptions options)
        {
            return SearchAsync(options).Result;
        }
    }

    partial class TWS_HotelList : ISearchResult
    {
        public IEnumerable<IHotelSearchResult> Hotels
        {
            get { return Hotel; }
        }
    }

    partial class TWS_HotelListHotel : IHotelSearchResult, IHotel
    {
        public IHotel Hotel
        {
            get { return this; }
        }

        private List<HotelPlacementOptionSearchResult> _roomSets;
        public IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions
        {
            get { return _roomSets ?? (_roomSets = RoomType.Select(rt => new HotelPlacementOptionSearchResult(rt, this)).ToList()); }
        }

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public int? Stars
        {
            get { return starsLevel; }
        }

        public string Description
        {
            get { return desc; }
        }

        public string ThumbnailImageUri
        {
            get { return thumb; }
        }

        public IEnumerable<string> ImagesUris { get { return null; } }
    }

    internal class HotelPlacementOptionSearchResult : IHotelPlacementOptionSearchResult
    {
        private readonly TWS_HotelListHotelRoomType _roomType;
        private readonly TWS_HotelListHotel _hotel;

        public HotelPlacementOptionSearchResult(TWS_HotelListHotelRoomType roomType, TWS_HotelListHotel hotel)
        {
            _roomType = roomType;
            _hotel = hotel;
        }

        public string Name
        {
            get { return _roomType.name; }
        }

        public string Currency
        {
            get { return _hotel.currency; }
        }

        public decimal Price
        {
            get { return _roomType.Occup.Sum(o => o.price); }
        }

        public IEnumerable<IRoom> Rooms
        {
            get { return null; }
        }

        public IEnumerable<string> Meals
        {
            get
            {
                return _roomType.Occup.Where(o => o.Board != null).Select(o => o.Board.name).Distinct();
            }
        }
    }
}