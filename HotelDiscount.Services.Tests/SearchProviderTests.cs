using System.Linq;
using HotelDiscount.Services.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelDiscount.Services.Tests
{
    [TestClass]
    public class SearchProviderTests
    {
        public TestContext TestContext { get; set; }

        protected void AssertSearchResults(ISearchResult result)
        {
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Hotels);
            Assert.IsTrue(result.Hotels.Any());

            var hotel = result.Hotels.First();

            Assert.IsFalse(string.IsNullOrEmpty(hotel.Hotel.Name));
            Assert.IsTrue(hotel.PlacementOptions.Any());

            var roomSet = hotel.PlacementOptions.First();

            Assert.IsFalse(string.IsNullOrEmpty(roomSet.Name));
            Assert.IsFalse(string.IsNullOrEmpty(roomSet.Currency));
            Assert.IsTrue(roomSet.Price > 0);
        }

        [TestMethod, DeploymentItem("source1.xml")]
        public void Source1Test()
        {
            var httpHandler = new FileMockHttpMessageHandler("source1.xml");
            var provider = Source1.Source1Provider.GetSearchProvider(httpHandler);
            var result = provider.Search(new SearchOptions());

            AssertSearchResults(result);
        }

        [TestMethod, DeploymentItem("source2.xml")]
        public void Source2Test()
        {
            var httpHandler = new FileMockHttpMessageHandler("source2.xml");
            var provider = Source2.Source2Provider.GetSearchProvider(httpHandler);
            var result = provider.Search(new SearchOptions());

            AssertSearchResults(result);
        }

        [TestMethod, DeploymentItem("source3.xml")]
        public void Source3Test()
        {
            var httpHandler = new FileMockHttpMessageHandler("source3.xml");
            var provider = Source3.Source3Provider.GetSearchProvider(httpHandler);
            var result = provider.Search(new SearchOptions());

            AssertSearchResults(result);

            Assert.AreEqual(3, result.Hotels.First().Hotel.Stars);
        }

        [TestMethod, DeploymentItem("source1.xml"), DeploymentItem("source2.xml"), DeploymentItem("source3.xml")]
        public void CompundTest()
        {
            var providers = new[]
            {
                Source1.Source1Provider.GetSearchProvider(new FileMockHttpMessageHandler("source1.xml")),
                Source2.Source2Provider.GetSearchProvider(new FileMockHttpMessageHandler("source2.xml")),
                Source3.Source3Provider.GetSearchProvider(new FileMockHttpMessageHandler("source3.xml"))
            };

            var provider = new CompoundSearchProvider(providers);
            var result = provider.Search(new SearchOptions());

            AssertSearchResults(result);
        }
    }
}
