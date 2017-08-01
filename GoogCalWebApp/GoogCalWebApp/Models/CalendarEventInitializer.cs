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
                new Event { Id = 2}
            };


            foreach(var temp in events)
            {
                context.Events.Add(temp);
            }

            context.SaveChanges();
        }
    }
}