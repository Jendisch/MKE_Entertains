using FoodDrinkDataAccess;
using EntertainmentDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKEntertains.Controllers
{
    public class MapController : Controller
    {
        MKERestaurantDealsEntities dealsDB = new MKERestaurantDealsEntities();
        MKEEntertainmentEntities entertainDB = new MKEEntertainmentEntities();

        // GET: Map
        public ActionResult FoodMap()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult EntertainmentMap()
        {
            DateTime todaysDate = DateTime.Now.Date;
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult MemberFoodMap()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult MemberEntertainmentMap()
        {
            DateTime todaysDate = DateTime.Now.Date;
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }


    }
}