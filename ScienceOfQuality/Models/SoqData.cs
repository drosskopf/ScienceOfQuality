using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScienceOfQuality.Models
{
    public class SoqData
    {

        public static List<SupportTicketModel> Tickets { get; set; }

         static SoqData()
        {
            Tickets = new List<SupportTicketModel>();
        }
    }
}