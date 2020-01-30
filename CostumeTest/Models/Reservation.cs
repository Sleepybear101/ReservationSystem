using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationGuest.Models
{
    public class Reservation
    {
     
        public int id { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; } = DateTime.Today;
        public string Daypart { get; set; }
        public int Table { get; set; } 
    }
}
