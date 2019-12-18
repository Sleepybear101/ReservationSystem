using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CostumeTest.Models;

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
        public IActionResult New(string controller) //Bound from Routing
        {
            Reservation user = new Reservation();
            user.Controller = controller;
            return View(user);
        }

        [HttpPost]
        public IActionResult New([FromForm]Reservation user) //Bound from FORM
        {
            var message = user.Name + " " + user.Email + ", Date of Birth: " + user.Amount.ToString() + ", Controller: " + user.Controller;
            return RedirectToAction("index", new { message = message });
        }
    }
}