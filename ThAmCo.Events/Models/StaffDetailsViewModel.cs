using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class StaffDetailsViewModel
    {
        public int StaffID { get; set; }

        public String FirstName { get; set; }

        public String Surname { get; set; }

        public String FullName { get; set; }

        public String StaffEmail { get; set; }

        public Boolean FirstAider { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}
