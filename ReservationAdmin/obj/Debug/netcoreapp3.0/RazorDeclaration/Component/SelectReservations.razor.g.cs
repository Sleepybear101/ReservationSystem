#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "791938d132ddbf986876536dfc9f4516623ec31b"
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
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using ReservationGuest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
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
#line 159 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"


    void SelectedDaypart(bool SelectedDaypart)
    {
        if (SelectedDaypart == false)
        {
            CreateRes.Daypart = "Lunch";
        }
        else
        {
            CreateRes.Daypart = "Dinner";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
