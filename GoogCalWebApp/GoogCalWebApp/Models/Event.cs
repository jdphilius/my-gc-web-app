using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoogCalWebApp.Models
{
    public class CalendarEvent
    {   
        public string Id { get; set; }

        public string Title { get; set; }

        public string Info { get; set; }

        public string Location { get; set; }

        public string StartDate { get; set; }

        

        public string EndDate { get; set; }



        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}