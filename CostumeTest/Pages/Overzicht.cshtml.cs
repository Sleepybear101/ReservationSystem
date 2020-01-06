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
    public class Overrview : PageModel
    {
        private readonly ILogger<Overrview> _logger;

        public Overrview(ILogger<Overrview> logger)
        {
            _logger = logger;
         
        }

        [BindProperty(SupportsGet = true)]
        public GuestInfo info  { get; set; }
        public void OnGet()
        {
  
        }
    }
}
