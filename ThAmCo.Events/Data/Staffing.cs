using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Data
{
    public class Staffing
    {
        public int EventID { get; set; }

        public Event Event { get; set; }

        public Staff Staff { get; set; }

        public int StaffID { get; set; }
    }
}
