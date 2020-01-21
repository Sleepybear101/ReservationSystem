#pragma checksum "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ab9e0758a49f308f964980987e8476ed024c1b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ReservationAdmin.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using ReservationAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class SelectReservations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
       
    Reservation CreateRes = new Reservation();
    SqlConnection con = new SqlConnection();


#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
 

    public string DateInText;
    public string DaypartText;
    void SelectedDaypart(bool SelectedDaypart)
    {
        if (SelectedDaypart == false)
        {
            CreateRes.Daypart = "Lunch";
            DaypartText = "Lunch 11:00 - 16:00";

        }
        else
        {
            CreateRes.Daypart = "Dinner";
            DaypartText = "Dinner 17:00 - 20:00";
        }

        DateInText = CreateRes.date.ToLongDateString();
    }
    //Verwijder de geselecteerde reservering
    void DeleteReservation(string ReservationID)
    {
        con.SqlQuery("DELETE FROM reservation WHERE reservation.id_Reservation = @ReservationID");
        con.Cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
        con.QueryEx();
    }
    //update de geselecteerde klant die niet is komen opdagen en verwijder de reservering
    void UpdateNoShow(string GuestID, string ReservationID)
    {
        con.SqlQuery("UPDATE guest set NoShow = NoShow + 1 WHERE id_Guest = @GuestID ");
        con.Cmd.Parameters.AddWithValue("@GuestID", GuestID);
        con.QueryEx();
        //Verwijderd de reservering van de klant die niet is komen opdagen
        DeleteReservation(ReservationID);
        UpdatedIsBlocked();
    }

    void UpdatedIsBlocked()
    {
        con.SqlQuery("UPDATE guest SET IsBlocked = 1 where NoShow = 3");
        con.QueryEx();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
