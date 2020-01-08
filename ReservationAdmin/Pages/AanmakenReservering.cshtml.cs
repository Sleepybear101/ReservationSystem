using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReservationAdmin.Pages
{
    public class CreateRes : PageModel
    {
        private readonly ILogger<CreateRes> _logger;

        public CreateRes(ILogger<CreateRes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
