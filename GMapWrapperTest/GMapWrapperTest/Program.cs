using System;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Geocoding.Request;
using GoogleMapsApi.Entities.Geocoding.Response;

namespace GMapWrapperTest
{
    class Program
    {
        static void Main()
        {
            //AIzaSyBeXsVM13DzGoRjEZXE2jKTTZ9qrU_R0NA   

            var geocodeRequest = new GeocodingRequest
            {
                Address = "kestucio g., Vilnius",
            };

            GeocodingResponse geocode = GoogleMaps.Geocode.Query(geocodeRequest);
            Console.WriteLine(geocode);

            foreach (Result result in geocode.Results)
            {
                Console.WriteLine(result.FormattedAddress);
            }
        }
    }
}
