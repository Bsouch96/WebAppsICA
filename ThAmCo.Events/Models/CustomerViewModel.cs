using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }

        public String FirstName { get; set; }

        public String Surname { get; set; }

        [DataType(DataType.EmailAddress)]
        public String CustomerEmailAddress { get; set; }

        public IEnumerable<Event> Event { get; set; }
    }
}