using RestaurantDealsDataAccess;
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

       
        public ActionResult FoodMap()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            if (today == "Saturday" || today == "Sunday")
            {
                return View("WeekendView");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult EntertainmentMap()
        {
            DateTime todaysDate = DateTime.Now.Date;
            string today = DateTime.Now.DayOfWeek.ToString();
            if (today == "Saturday" || today == "Sunday")
            {
                return View("WeekendView");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult MemberFoodMap()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            if (today == "Saturday" || today == "Sunday")
            {
                return View("MemberFoodWeekendView");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == today);

            return View(dealInformation);
        }

        public ActionResult MemberEntertainmentMap()
        {
            DateTime todaysDate = DateTime.Now.Date;
            string today = DateTime.Now.DayOfWeek.ToString();
            if (today == "Saturday" || today == "Sunday")
            {
                return View("MemberEntertainmentWeekendView");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult WeekendViewPlanAhead()
        {
            return View();
        }


        //Future Food Maps

        public ActionResult FoodMapDayPlusOne()
        {
            string day = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            if(day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusTwo()
        {
            string day = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusThree()
        {
            string day = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusFour()
        {
            string day = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusFive()
        {
            string day = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusSix()
        {
            string day = DateTime.Now.AddDays(6).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        public ActionResult FoodMapDayPlusSeven()
        {
            string day = DateTime.Now.AddDays(7).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var dealInformation = dealsDB.Deals.Where(a => a.DayOfTheWeek == day);

            return View(dealInformation);
        }

        //Future Entertainment Maps

        public ActionResult EntertainmentMapDayPlusOne()
        {
            DateTime todaysDate = DateTime.Now.AddDays(1).Date;
            string day = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusTwo()
        {
            DateTime todaysDate = DateTime.Now.AddDays(2).Date;
            string day = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusThree()
        {
            DateTime todaysDate = DateTime.Now.AddDays(3).Date;
            string day = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusFour()
        {
            DateTime todaysDate = DateTime.Now.AddDays(4).Date;
            string day = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusFive()
        {
            DateTime todaysDate = DateTime.Now.AddDays(5).Date;
            string day = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusSix()
        {
            DateTime todaysDate = DateTime.Now.AddDays(6).Date;
            string day = DateTime.Now.AddDays(6).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }

        public ActionResult EntertainmentMapDayPlusSeven()
        {
            DateTime todaysDate = DateTime.Now.AddDays(7).Date;
            string day = DateTime.Now.AddDays(7).DayOfWeek.ToString();
            if (day == "Saturday" || day == "Sunday")
            {
                return View("WeekendViewPlanAhead");
            }
            var entertainmentInfo = entertainDB.Events.Where(b => b.Date == todaysDate);

            return View(entertainmentInfo);
        }



    }
}