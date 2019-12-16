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

        
        public void OnGet()
        {
          
        }
    }
}
