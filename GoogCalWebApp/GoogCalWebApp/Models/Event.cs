using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoogCalWebApp.Models
{
    public class Event
    {   
        public int Id { get; set; }

        public string Title { get; set; }

        public string Info { get; set; }

        public string Location { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}