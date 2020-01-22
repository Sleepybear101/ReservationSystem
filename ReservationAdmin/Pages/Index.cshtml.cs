using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ReservationGuest.Models;

namespace ReservationAdmin.Pages
{
    public class IndexModel : PageModel
    {
        SqlConnection _con = new SqlConnection();
        [BindProperty(SupportsGet = true)]
        private string password { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public void OnGet()
        {


        }
       

        public IActionResult OnPost()
        {
            string  number = "1"; 
            return RedirectToPage("Dashboard" , new { idAdmin=number });
        }


    }
}