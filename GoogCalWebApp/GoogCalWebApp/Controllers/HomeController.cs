using GoogCalWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogCalWebApp.Controllers
{
    public class HomeController : Controller
    {
        private CalendarEventContext db = new CalendarEventContext();

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";




        [Authorize]
        public ActionResult Index()
        {
            try
            {
                //Google authentication using OAuth for users calendar
                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "113467810390-j9sevqku1el90kf4vkef419vaa2ncukk.apps.googleusercontent.com",
                    ClientSecret = "IzyO4e9TseAXP6I1TY5slAol",
                },
                new[] { CalendarService.Scope.Calendar },
                "user",
                CancellationToken.None).Result;

                // Create the service.
                var calservice = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Calendar API Sample",
                });


                EventsResource.ListRequest req = calservice.Events.List("primary");
                req.TimeMin = Convert.ToDateTime(DateTime.Now);
                req.TimeMax = Convert.ToDateTime(req.TimeMin).AddDays(30.0);
                req.SingleEvents = true;
                req.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;
                Events events = req.Execute();

                foreach (var eventdata in events.Items)
                {
                    var item = new CalendarEvent
                    {
                        Id = eventdata.Id,
                        Title = eventdata.Summary,
                        Info = eventdata.Description,
                        Location = eventdata.Location

                    };
                    EventDateTime start = eventdata.Start;
                    item.StartDate = Convert.ToString(start.DateTime);
                    item.StartTime = Convert.ToDateTime(start.DateTime).ToString("HH:mm");
                    EventDateTime end = eventdata.End;
                    item.EndDate = Convert.ToString(end.DateTime);
                    item.EndTime = Convert.ToDateTime(end.DateTime).ToString("HH:mm");
                }

               //calendarEvents.Add(item);




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