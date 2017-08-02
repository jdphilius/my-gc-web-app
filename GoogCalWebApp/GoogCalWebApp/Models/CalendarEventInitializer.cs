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
            var events = new List<CalendarEvent>
            {
                new CalendarEvent { Id = "1", 
                            StartDate = DateTime.Parse("01/01/2017").ToString(), 
                            EndDate = DateTime.Parse("01/01/2017").ToString(),
                            Title = "DevOps meeting",
                            Info = "Discussion around continuous integration & continuous deployment.",
                            Location = "Lightning Conference Room." }
            };

            events.ForEach(x => context.Events.Add(x));

            context.SaveChanges();
        }
    }
}