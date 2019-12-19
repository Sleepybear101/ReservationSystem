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
        
        public string Name { get; set; } = "wurud";
        public string Email { get; set; } = "test@mail.com";
        public int Amount { get; set; } = 2;
        public string Controller { get; set; }
       }
}
 