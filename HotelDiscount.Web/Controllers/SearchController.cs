using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using HotelDiscount.Services;
using HotelDiscount.Services.Models;
using HotelDiscount.Web.Models;
using HotelDiscount.Web.Models.Search;

namespace HotelDiscount.Web.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        private static readonly Lazy<ISearchProvider> SearchProvider = new Lazy<ISearchProvider>(() => new CompoundSearchProvider(
            new[]
            {
                Services.Source1.Source1Provider.GetSearchProvider(),
                Services.Source2.Source2Provider.GetSearchProvider(),
                Services.Source3.Source3Provider.GetSearchProvider()
            }));

        public static SearchOptions PresetSearchOptions = new SearchOptions
        {
            City = "Зальцбург",
            DateFrom = new DateTime(2013, 9, 1),
            DateTo = new DateTime(2013, 9, 7),
            Rooms = new[] {new RoomSearchOption {AdultCount = 1}, new RoomSearchOption {AdultCount = 2, ChildCount = 1}}
        };

        public static SearchInputModel PresetInputModel = new SearchInputModel
        {
            City = PresetSearchOptions.City,
            DateFrom = PresetSearchOptions.DateFrom,
            DateTo = PresetSearchOptions.DateTo,
            RoomsDescription = "один одноместный, один двухместный с дополнительной кроватью"
        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(new SearchOutputModel {Input = PresetInputModel});
        }

        [HttpPost]
        public async Task<ActionResult> Index(SearchInputModel searchInputModel)
        {
            return View(new SearchOutputModel
            {
                Input = PresetInputModel,
                SearchResult = new SearchResult(await SearchProvider.Value.SearchAsync(PresetSearchOptions))
            });
        }
    }
}
