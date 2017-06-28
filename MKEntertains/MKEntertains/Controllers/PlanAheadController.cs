using Microsoft.AspNet.Identity;
using MKEntertains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKEntertains.Controllers
{
    public class PlanAheadController : Controller
    {

        private ApplicationDbContext userDB = new ApplicationDbContext();

        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            ApplicationUser currentUser = userDB.Users.Find(userId);

            return View("Index", currentUser);
        }
    }
}