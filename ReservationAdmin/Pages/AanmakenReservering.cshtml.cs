using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace ReservationAdmin.Pages
{
    public class CreateRes : PageModel
    {
        private readonly ILogger<CreateRes> _logger;

        public CreateRes(ILogger<CreateRes> logger)
        {
            _logger = logger;
        }

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
