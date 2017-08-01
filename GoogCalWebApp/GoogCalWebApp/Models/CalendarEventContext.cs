using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoogCalWebApp.Models
{
    public class CalendarEventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}