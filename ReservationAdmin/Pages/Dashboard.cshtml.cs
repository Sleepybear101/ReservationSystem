﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReservationAdmin.Models;
using System.Timers;
using Microsoft.AspNetCore.Http;




namespace ReservationAdmin.Pages
{
    public class DashboardModel : PageModel
    {

        public string Admin;
        [BindProperty(SupportsGet = true)]
        public string subject { get; set; }
        public IActionResult OnGet()
        {
               Admin = HttpContext.Session.GetString("token");
            if (Admin != "true")
            {
                return Redirect("Index");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost()
        {
            if (subject == "Index")
            {
                Admin = "False";
                HttpContext.Session.SetString("token", Admin);        
                return RedirectToPage("/" + subject + "");


            }
            else
            {
                return RedirectToPage("/" + subject + "");

            }


        }

    }
}