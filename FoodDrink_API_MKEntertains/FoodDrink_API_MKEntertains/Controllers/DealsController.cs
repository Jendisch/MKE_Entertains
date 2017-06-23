using DealsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodDrink_API_MKEntertains.Controllers
{
    public class DealsController : ApiController
    {

        MKERestaurantDealsEntities db = new MKERestaurantDealsEntities();

        //Get List of Deals
        public IEnumerable<Deal> Get()
        {
            using (MKERestaurantDealsEntities db = new MKERestaurantDealsEntities())
            {
                return db.Deals.OrderBy(a => a.Location.Name).ToList();
            }
        }

        public IHttpActionResult Get(int id)
        {
            var deal = db.Deals.FirstOrDefault(e => e.Id == id);
            if (deal == null)
            {
                return NotFound();
            }
            return Ok(deal);
        }



    }
}
