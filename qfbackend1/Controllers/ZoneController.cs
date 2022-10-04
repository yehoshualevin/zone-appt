using Geocoding;
using Geocoding.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using qfbackend1.BusinessModels;
using qfbackend1.Models;

namespace qfbackend1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        // GET: api/Zone/'hi'
        [HttpGet]
        public async Task<ZoneData> Get(string address)
        {
            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyAIAs1I7bRsZoC9sMPg1FT8_ehUoQl1vGQ" };
            IEnumerable<Address> addresses = await geocoder.GeocodeAsync($"{address} NJ");
            Location location = addresses.FirstOrDefault().Coordinates;
            double latitude = location.Latitude;
            double longitude = location.Longitude;
            int zoneNumber = GetZone.Run(latitude, longitude);

            ZoneData zoneData = new ZoneData() { ZoneNumber = zoneNumber};

            return zoneData;
        }
    }
}
