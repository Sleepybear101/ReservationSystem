using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CostumeTest.Pages;

namespace ReservationGuest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult Index() //Bound from Query String
        {
            
            return Redirect("overzicht");
        }
    

     
    }
}