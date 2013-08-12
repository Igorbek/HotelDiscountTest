using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HotelDiscount.Services.Tests
{
    internal class FileMockHttpMessageHandler : HttpMessageHandler
    {
        public string Path { get; set; }

        public FileMockHttpMessageHandler(string path)
        {
            Path = path;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return new HttpResponseMessage(HttpStatusCode.OK) {Content = new StreamContent(File.OpenRead(Path))};
        }
    }
}