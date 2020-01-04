using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    public class EventEditViewModel
    {
        public int EventID { get; set; }

        public string EventTitle { get; set; }

        public TimeSpan? EventDuration { get; set; }

    }
}
