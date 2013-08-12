using System;
using System.IO;
using System.Threading.Tasks;
using HotelDiscount.Services.Models;

namespace HotelDiscount.Services
{
    public interface ISearchProvider
    {
        Task<ISearchResult> SearchAsync(SearchOptions options);
        ISearchResult Search(SearchOptions options);
    }
}