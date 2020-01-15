using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAdmin.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; }
        public string Daypart { get; set; }
        public int Table { get; set; }
        public int IsBlocked { get; set; }
    }
}
