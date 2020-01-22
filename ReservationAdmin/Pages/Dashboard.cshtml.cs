using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReservationAdmin.Models;

namespace ReservationAdmin.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Admin { get; set; }

        public IActionResult OnGet()
        {
            if(Admin == "" || Admin == null)
            {
                return Redirect("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}