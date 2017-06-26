using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestaurantDataAccess;

namespace Restaurant_API.Controllers
{
    public class DealsController : ApiController
    {

        public IEnumerable<DailyDeal> Get()
        {
            using (MKERestaurantDealsEntities db = new MKERestaurantDealsEntities())
            {
                return db.DailyDeals.ToList();
            }
        }

        public DailyDeal Get(int id)
        {
            using (MKERestaurantDealsEntities db = new MKERestaurantDealsEntities())
            {
                return db.DailyDeals.FirstOrDefault(a => a.Id == id);
            }
        }






    }
}
