using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAdmin.Models
{
    public class Reservation
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string Amount { get; set; }
        public DateTime date { get; set; }
        public string dagdeel { get; set; }
        public int tafel { get; set; }

    }
}
