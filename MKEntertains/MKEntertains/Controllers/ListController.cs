using EntertainmentDataAccess;
using MKEntertains.Models;
using RestaurantDealsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace MKEntertains.Controllers
{
    public class ListController : Controller
    {
        MKERestaurantDealsEntities dealsDB = new MKERestaurantDealsEntities();
        MKEEntertainmentEntities entertainDB = new MKEEntertainmentEntities();
        YelpAPIClient yelp = new YelpAPIClient();
        public string rating;


        
        public async Task<ViewResult> FoodYelpInfo(double latitude, double longitude, string name, string phoneNumber)
        {
            var business = await yelp.FoodAPIRequest(latitude, longitude, name, phoneNumber);
            return View(business);
        }


        public ActionResult FoodList()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

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
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

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