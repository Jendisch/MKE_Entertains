using EntertainmentDataAccess;
using FoodDrinkDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKEntertains.Controllers
{
    public class ListController : Controller
    {
        MKERestaurantDealsEntities db = new MKERestaurantDealsEntities();
        MKEEntertainmentEntities entertainDB = new MKEEntertainmentEntities();

        // GET: List
        public ActionResult FoodList()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            var dealInformation = db.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult EntertainmentList()
        {
            DateTime todaysDate = DateTime.Now.Date;
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult MemberFoodList()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            var dealInformation = db.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult MemberEntertainmentList()
        {
            DateTime todaysDate = DateTime.Now.Date;
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

    }
}