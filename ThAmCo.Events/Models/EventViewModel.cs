using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class EventViewModel
    {
        public int EventID { get; set; }

        public String EventTitle { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan? Duration { get; set; }

        [Required, MaxLength(3), MinLength(3)]
        public String TypeId { get; set; }

        public int NumberOfGuests { get; set; }

        public int NumberOfStaff { get; set; }

        public Boolean SufficientStaff { get; set; }

        public String SufficientStaffMessage { get; set; }

        public String FirstAiderMessage { get; set; }

        public Boolean FirstAiderPresent { get; set; }

        public IEnumerable<GuestViewModel> Guests { get; set; }

        public IEnumerable<StaffViewModel> Staff { get; set; }
    }
}