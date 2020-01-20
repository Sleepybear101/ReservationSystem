using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using ReservationGuest.Models;

namespace ReservationGuest.Pages
{
    public class ConfirmModel : PageModel
    {
        SqlConnection con = new SqlConnection();

        [BindProperty(SupportsGet = true)]

        public string GetGuestid { get; set; }
        [BindProperty(SupportsGet = true)]
        public string GetRes{ get; set; }
        [BindProperty(SupportsGet = true)]
        public string GetReservationDaypart { get; set; }
        public void OnGet()
        {
            con.SqlQuery("UPDATE `reservation` SET `IsConfirm`='Ja' WHERE `id_Reservation`=@idRes AND `Guest`=@Guest");
            con.Cmd.Parameters.AddWithValue("@Guest", GetGuestid);
            con.Cmd.Parameters.AddWithValue("@idRes", GetRes);
            con.NonQueryEx();

        }

  

    }
}