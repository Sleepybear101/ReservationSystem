using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationGuest.Models
{
    public class Reservation
    {
        public string FullName { get; set; }

        public string Email { get; set; }
        public string Amount { get; set; }
        public DateTime date { get; set; }
        public string Daypart { get; set; }
        public int Table { get; set; }

    }
}
