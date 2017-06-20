using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MKEDealsAccess;

namespace MKEntertains.Controllers
{
    public class DealsController : ApiController
    {
        MKERestaurantDealsEntities db = new MKERestaurantDealsEntities();

        public IEnumerable<DailyDeal> Get()
        {
            using (MKERestaurantDealsEntities db = new MKERestaurantDealsEntities())
            {
                return db.DailyDeals.ToList();
            }
        }

        public IHttpActionResult Get(int id)
        {
            var deal = db.DailyDeals.FirstOrDefault(e => e.Id == id);
            if (deal == null)
            {
                return NotFound();
            }
            return Ok(deal);
        }



    }
}
