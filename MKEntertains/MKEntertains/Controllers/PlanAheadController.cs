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
using Mailgun.Messages;
using Mailgun.Service;

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
                return View("ConfirmPlanAheadSuccessful", currentUser);
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

        public async System.Threading.Tasks.Task<ActionResult> SendReminderEmail(string id)
        {

            ApplicationUser currentUser = userDB.Users.Find(id);
            var sched = currentUser.schedules.Last();
            DateTime dayBefore = sched.MKEntertainDate.Value.Subtract(TimeSpan.FromDays(1));
            TimeZone currentTimeZone = TimeZone.CurrentTimeZone;

            string messageDescription;
            if (sched.Description == null || sched.Description == "")
            {
                messageDescription = "No description was given while creating this event.";
            }
            else
            {
                messageDescription = sched.Description;
            }

            var mg = new MessageService("8f5f62fd6afc1adcd42f3ea92c4b12cf");
            string domain = "mkentertains.com";
            var message = new MessageBuilder()
                .AddToRecipient(new Recipient
                {
                    Email = currentUser.Email,
                    DisplayName = currentUser.UserName
                })
                .SetDeliveryTime(dayBefore, currentTimeZone)
                .SetTestMode(true)
                .SetSubject("MKEntertains Reminder")
                .SetFromAddress(new Recipient { Email = "Admin@mkentertains.com", DisplayName = "Admin" })
                .SetTextBody($"Hello!\nHere is your reminder for your MKEntertains event you scheduled on {DateTime.Now.Date}.\n\n--Scheduled Date: {sched.MKEntertainDate.Value.Date}\n--Restaurant/Bar Location: {sched.FoodDrinkChoice}\n--Entertainment Location: {sched.EntertainmentChoice}\n--EventDescription: {messageDescription}\n\n\nThank you for using MKEntertains to help plan your nights out in Milwaukee!\nVisit us again soon.")
                .GetMessage();

            var content = await mg.SendMessageAsync(domain, message);
            //content.ShouldNotBeNull();

            return View("ConfirmEmailSent");
        }



    }
}
