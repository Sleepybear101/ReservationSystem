using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAdmin.Models
{
    public class Reservation
    {
     
        public int Amount { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public string Daypart { get; set; }
        public int Table { get; set; } 
    }
}
