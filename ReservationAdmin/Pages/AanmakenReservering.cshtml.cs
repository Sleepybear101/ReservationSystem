using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReservationAdmin.Pages
{
    public class PoenkModel : PageModel
    {
        private readonly ILogger<PoenkModel> _logger;

        public PoenkModel(ILogger<PoenkModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
