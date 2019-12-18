using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CostumeTest.Models
{
    public class Reservation
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public string Controller { get; set; }
    }
}
 