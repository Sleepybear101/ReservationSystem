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
        public IActionResult Index(string message) //Bound from Query String
        {
            ViewData["message"] = message;
            return View();
        }

        [HttpGet]
       /* public IActionResult New(string controller,string Name, string Email, int Amount) //Bound from Routing
        {
            user.Name = Name  ;
            user.Email = Email;
            user.Amount = Amount;
            user.Controller = controller;
            return View(user);
        }*/

        [HttpPost]
        public IActionResult FormsTestPost()
        {       
            Reservation user = new Reservation();
            user.Name = HttpContext.Request.Form["Name"];
            user.Email = HttpContext.Request.Form["Email"];
            user.Amount = HttpContext.Request.Form["Amount"];
            return Redirect("Datum");
             
        }
    }
}