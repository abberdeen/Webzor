using Bunit;
using Webzor.BrowserApi.Geolocation;

namespace UnitTests
{
    public class GeolocationApiTests
    {
        [Fact]
        public async Task Test1Async()
        { 
            var geo = new GeolocationApi( null);

           await geo.GetCurrentLoaction();
        }
    }
}