﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace CostumeTest.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
         private string password { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public void OnGet()
        {




        }


    /*public void CheckMail()
        {
            if(ModelState.IsValid == false)
            {
                return;
            }
            /* PUT BACK IF NOT WORKING
              return  RedirectToPage("Datum", new { info.Name, info.Email, info.Amount });
               //return RedirectToPage("Datum");
               */
        
        //}
       
    }
}
