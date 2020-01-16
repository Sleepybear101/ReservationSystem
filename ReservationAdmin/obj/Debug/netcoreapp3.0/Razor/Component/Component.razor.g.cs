#pragma checksum "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b8755b63f5adc3170c31e2c60bbbc082d8eeb0"
// <auto-generated/>
#pragma warning disable 1591
namespace ReservationAdmin.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
using ReservationAdmin.Models;

#line default
#line hidden
#nullable disable
    public class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "id", "myTable");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddAttribute(3, "cellspacing", "0");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 17 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
              
                con.SqlQuery("SELECT reservation.Date, reservation.DayPart, reservation.TableNumber, reservation.Amount, reservation.IsConfirm, guest.FullName FROM reservation INNER JOIN guest ON reservation.Guest = guest.id_Guest WHERE reservation.Date = @date AND reservation.DayPart = @Daypart");
                con.Cmd.Parameters.AddWithValue("@date", "2019-01-01");
                con.Cmd.Parameters.AddWithValue("@Daypart", "dinner");
                con.QueryEx();
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n        <td>full name</td>\r\n        <td>tablenumber</td>\r\n        <td>amount of people</td>\r\n\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 32 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
         foreach (DataRow dr in con.QueryEx().Rows)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 35 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
                 dr[5].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 36 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
                 dr[2].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 37 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
                 dr[3].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 39 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\Component.razor"
       

    SqlConnection con = new SqlConnection();
    Reservation CreateRes = new Reservation();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
