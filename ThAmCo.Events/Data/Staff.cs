using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Data
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required]
        public string StaffSurname { get; set; }

        [Required]
        public string StaffFirstName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string StaffEmail { get; set; }

        public Boolean FirstAider { get; set; }

        public List<Staffing> Staffing { get; set; }
    }
}
