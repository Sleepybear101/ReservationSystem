using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CostumeTest.Models
{
    public class GuestInfo
    {
        public string Name { get; set; }
       
        public string Email { get; set; }
        public string Amount { get; set; }
        public string date { get; set; }
        public string dagdeel { get; set; }

    }
}
 