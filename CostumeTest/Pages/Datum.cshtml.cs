using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostumeTest.Models;
using CostumeTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CostumeTest.Pages
{
    public class Datemodel : PageModel
    {
        private readonly ILogger<Datemodel> _logger;

        public Datemodel(ILogger<Datemodel> logger)
        {
            _logger = logger;
            
        }
        [BindProperty(SupportsGet = true)]
        public GuestInfo info { get; set; } 
        public void OnGet()
        {
      

               
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Redirect("Overzicht");
            }


            return RedirectToPage("Dagdeel", new { info.Name, info.Email, info.Amount , info.date});

        }


    }
}
