using System;

namespace HotelDiscount.Web.Models.Search
{
    public class SearchInputModel
    {
        public string City { get; set; } 
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string RoomsDescription { get; set; }
    }

    public class SearchOutputModel
    {
        public SearchInputModel Input { get; set; }
        public SearchResult SearchResult { get; set; }
    }
}