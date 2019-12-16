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
    public class DayPartModel : PageModel
    {
        private readonly ILogger<DayPartModel> _logger;

        public DayPartModel(ILogger<DayPartModel> logger)
        {
            _logger = logger;
         
        }

        
        public void OnGet()
        {
          
        }
    }
}
