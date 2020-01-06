using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CostumeTest.Models;
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
            
            return Redirect("Datum");
        }
        [BindProperty(SupportsGet = true)]
        public GuestInfo info { get; set; }

        [HttpPost]
        public IActionResult OnPost()
        {

            return RedirectToAction("index",info);

        }
     
    }
}