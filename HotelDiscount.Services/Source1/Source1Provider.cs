using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Services.Source1
{
    public static class Source1Provider
    {
        public static ISearchProvider GetSearchProvider(HttpMessageHandler httpMessageHandler = null)
        {
            return new Source1SearchProvider(httpMessageHandler);
        }

        internal static readonly Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(()=>new XmlSerializer(typeof(Response)), true);
        public const string SeriveUri = "http://rs.hoteldiscount.ru/tsrc.aspx?p=1";
    }

    internal class Source1SearchProvider : ISearchProvider
    {
        private readonly HttpMessageHandler _httpMessageHandler;

        public Source1SearchProvider(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
        }

        public async Task<ISearchResult> SearchAsync(SearchOptions options)
        {
            var client = _httpMessageHandler == null ? new HttpClient() : new HttpClient(_httpMessageHandler);
            var stream = await client.GetStreamAsync(Source1Provider.SeriveUri);
            return (Response)Source1Provider.Serializer.Value.Deserialize(stream);
        }

        public ISearchResult Search(SearchOptions options)
        {
            return SearchAsync(options).Result;
        }
    }

    partial class Response : ISearchResult
    {
        public IEnumerable<IHotelSearchResult> Hotels
        {
            get { return ResponseDetails.SearchHotelPriceResponse.HotelDetails; }
        }
    }

    partial class ResponseResponseDetailsSearchHotelPriceResponseHotel : IHotelSearchResult, IHotel
    {
        public IHotel Hotel
        {
            get { return this; }
        }

        public IEnumerable<IHotelPlacementOptionSearchResult> PlacementOptions
        {
            get { return RoomCategories; }
        }

        public string Name { get { return Item.Value; } }

        public string Address
        {
            get { return null; }
        }

        public int? Stars
        {
            get { return StarRating; }
        }

        public string Description
        {
            get { return null; }
        }

        public string ThumbnailImageUri
        {
            get { return null; }
        }

        public IEnumerable<string> ImagesUris { get { return null; } }
    }

    partial class ResponseResponseDetailsSearchHotelPriceResponseHotelRoomCategory : IHotelPlacementOptionSearchResult
    {
        public string Name
        {
            get { return Description; }
        }

        public string Currency
        {
            get { return ItemPrice.Currency; }
        }

        public decimal Price
        {
            get { return ItemPrice.Value; }
        }

        public IEnumerable<IRoom> Rooms
        {
            get { return null; }
        }

        private List<string> _meals;
        IEnumerable<string> IHotelPlacementOptionSearchResult.Meals
        {
            get
            {
                if (_meals == null)
                {
                    _meals = new List<string>(2);
                    if (Meals.Basis != null)
                        _meals.Add(Meals.Basis.Value);
                    if (Meals.Breakfast != null)
                        _meals.Add(Meals.Breakfast.Value);
                }
                return _meals;
            }
        }
    }
}