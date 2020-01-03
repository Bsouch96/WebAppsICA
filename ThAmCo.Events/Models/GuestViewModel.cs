using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class GuestViewModel
    {
        public int GuestID { get; set; }

        public String FirstName { get; set; }

        public String Surname { get; set; }

        public String FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string GuestEmail { get; set; }

        public Boolean Attended { get; set; }
    }
}