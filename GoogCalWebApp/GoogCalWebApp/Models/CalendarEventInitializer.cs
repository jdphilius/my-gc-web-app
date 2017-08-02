using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoogCalWebApp.Models
{
    public class CalendarEventInitializer: DropCreateDatabaseIfModelChanges<CalendarEventContext>
    {
        protected override void Seed(CalendarEventContext context)
        {
            var events = new List<Event>
            {
                new Event { Id = 1, 
                            From = DateTime.Parse("01/01/2017"), 
                            To = DateTime.Parse("01/01/2017"),
                            Title = "DevOps meeting",
                            Info = "Discussion around continuous integration & continuous deploymnet.",
                            Location = "Lightning Conference Room." }
            };

            events.ForEach(x => context.Events.Add(x));

            context.SaveChanges();
        }
    }
}