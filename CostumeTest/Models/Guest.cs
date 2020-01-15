using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationGuest.Models
{
    public class Guest
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int IsBlocked { get; set; }
    }
}
