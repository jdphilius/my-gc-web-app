using GoogCalWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogCalWebApp.Controllers
{
    public class HomeController : Controller
    {
        private CalendarEventContext db = new CalendarEventContext();

        public ActionResult Index()
        {
            try
            {
                var calendarEvents = db.Events.ToList(); 
                return View(calendarEvents);

            }
            catch (Exception) 
            {
                
                throw;
            }
            

            
            
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}