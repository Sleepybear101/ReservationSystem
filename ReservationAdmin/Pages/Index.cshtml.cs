using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ReservationGuest.Models;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace ReservationAdmin.Pages
{
    public class IndexModel : PageModel
    {
        SqlConnection _con = new SqlConnection();
        [BindProperty(SupportsGet = true)]
        public string password { get; set; }
       public string Admin { get; set;  }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public void OnGet()
        {


        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));
                // Convert byte array to a string
                System.Text.StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public IActionResult OnPost()
        {
            var hPassword = ComputeSha256Hash(password);

            _con.SqlQuery("SELECT `id_Admin` FROM `admin` WHERE `Password`= @Hpassword");
            _con.Cmd.Parameters.AddWithValue("@Hpassword", hPassword);
            _con.QueryEx();
            foreach (DataRow dr in _con.QueryEx().Rows)
            {
                Admin = dr[0].ToString();
            }

            return RedirectToPage("Dashboard", new { Admin = Admin });
        }

    }
}