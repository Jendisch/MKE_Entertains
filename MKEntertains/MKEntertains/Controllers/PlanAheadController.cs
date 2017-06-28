using EntertainmentDataAccess;
using Microsoft.AspNet.Identity;
using MKEntertains.Models;
using RestaurantDealsDataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace MKEntertains.Controllers
{
    public class PlanAheadController : Controller
    {

        private MKERestaurantDealsEntities dealsDB = new MKERestaurantDealsEntities();
        private MKEEntertainmentEntities entertainDB = new MKEEntertainmentEntities();
        private ApplicationDbContext userDB = new ApplicationDbContext();

        public ActionResult Index()
        {
            var dealsList = dealsDB.Locations.Select(a => a.Name).Distinct();
            ViewBag.dealsList = dealsList;

            var entertainmentList = entertainDB.Locations.Select(a => a.Name).Distinct();
            ViewBag.entertainmentList = entertainmentList;

            Schedule schedule = new Schedule();

            return View("Index", schedule);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Schedule currentSchedule)
        {
            string userId = User.Identity.GetUserId();
            ApplicationUser currentUser = userDB.Users.Find(userId);

            try
            {
                DateTime convertedDate = Convert.ToDateTime(currentSchedule.MKEntertainDate);

                Schedule newEvent = new Schedule();
                newEvent.UserId = currentUser.Id;
                newEvent.MKEntertainDate = convertedDate;
                newEvent.FoodDrinkChoice = currentSchedule.FoodDrinkChoice;
                newEvent.EntertainmentChoice = currentSchedule.EntertainmentChoice;
                newEvent.Description = currentSchedule.Description;
                newEvent.ApplicationUser = currentUser;
                currentUser.schedules.Add(newEvent);

                userDB.SaveChanges();
                return RedirectToAction("ConfirmPlanAheadSuccessful", "PlanAhead");
            }
            catch
            {
                var dealsList = dealsDB.Locations.Select(a => a.Name).Distinct();
                ViewBag.dealsList = dealsList;

                var entertainmentList = entertainDB.Locations.Select(a => a.Name).Distinct();
                ViewBag.entertainmentList = entertainmentList;

                Schedule schedule = new Schedule();

                return View("SomethingWentWrongIndex", schedule);
            }
        }

        public ActionResult ConfirmPlanAheadSuccessful()
        {
            return View();
        }

        public ActionResult SomethingWentWrongIndex()
        {
            return View();
        }



    }
}

//try
//            {
//                DateTime convertedDate = Convert.ToDateTime(date);
//currentUser.schedule.MKEntertainDate = convertedDate;
//                currentUser.schedule.FoodDrinkChoice = restaurant;
//                currentUser.schedule.EntertainmentChoice = entertainment;
//                currentUser.schedule.Description = description;
//                userDB.Entry(currentUser).State = EntityState.Modified;
//                userDB.SaveChanges();
//                return RedirectToAction("ConfirmPlanAheadSuccessful", "PlanAhead");
//            }
//            catch
//            {
//                var dealsList = dealsDB.Locations.Select(a => a.Name).Distinct();
//ViewBag.dealsList = dealsList;

//                var entertainmentList = entertainDB.Locations.Select(a => a.Name).Distinct();
//ViewBag.entertainmentList = entertainmentList;

//                return View("SomethingWentWrongIndex", currentUser);
//            }