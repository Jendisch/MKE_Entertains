using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RapidAPISDK;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Yelp.Api.Models;
using RestaurantDealsDataAccess;

namespace MKEntertains.Models
{
    public class YelpAPIClient
    {
        //private static RapidAPI RapidApi = new RapidAPI("mkentertains_59515a16e4b03a5acfb1cc69", token: "/connect/auth/mkentertains_59515a16e4b03a5acfb1cc69");




        private const string clientId = "zM1rzJePyFzwaD6yqvJXeg";
        private const string clientSecret = "GuOqlZrJDovsYTUyYYl2pgsFUWJpoH8MESxRf0JnCJe6okHjJK9lSCsfadvDW67Y";
        private const string token = "mMCU8diwBF6aEATHzAPPI0Hbe6NbovjG1c1MY2Ro0P8kiFpDiAOusr3mKKmytXF7qrg8qikTLmH895a0yX0A5Ws6VpZ782SECmwAq7lpJqRW_kSDwPS2JzhOKh5RWXYx";
        private const string apiHost = "https://api.yelp.com";
        private const string searchPath = "/v3/businesses/search/";


        public async Task<BusinessResponse> FoodAPIRequest(double latitude, double longitude, string name, string phoneNumber)
        {
            var client = new Yelp.Api.Client(clientId, clientSecret);

            var results = await client.SearchBusinessesAllAsync(name, latitude, longitude);
            var correctBusiness = results.Businesses.Where(a => a.DisplayPhone == phoneNumber).FirstOrDefault();
            

            return correctBusiness;
        }
        


    }
}