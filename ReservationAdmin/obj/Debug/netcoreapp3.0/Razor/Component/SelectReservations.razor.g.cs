#pragma checksum "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5791e949d3168a41bb890d874df7f14528d20686"
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
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n\r\n        ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "background-color:#D5DAD7; float :left; width: 35%;  height: 100vh;");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.AddMarkupContent(5, "<p style=\"margin-left: 7%; color: #9597A6; font-size: 24px;padding-top: 5px;    margin-bottom: 5px;\">Agenda</p>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "border-top: 1px solid;padding-bottom: 7px;   margin-left: 2%; width: 95%; ");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "margin-top:30px;");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.AddMarkupContent(12, "<h4>Datum</h4>\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "Form-date");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", " margin-left: 23px;");
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n                                    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "date");
            __builder.AddAttribute(25, "id", "txtDate");
            __builder.AddAttribute(26, "onkeydown", "return false");
            __builder.AddAttribute(27, "class", "input-group-addon date-div unstyled form-control");
            __builder.AddAttribute(28, "max", "2025-01-1");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                           CreateRes.date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.date = __value, CreateRes.date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "margin-top: 18%;");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.AddMarkupContent(39, "<h4>Dagdeel</h4>\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "Daypart-div");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "Daypart");
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                (e => SelectedDaypart(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "btn Daypart-btn Daypart-btn-lunch");
            __builder.AddMarkupContent(50, "\r\n                                    ");
            __builder.AddMarkupContent(51, "<h5>Lunch</h5>\r\n                                    ");
            __builder.AddMarkupContent(52, "<p>11:00 - 16:00</p>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                (e=> SelectedDaypart(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "class", "btn Daypart-btn   Daypart-btn-diner");
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.AddMarkupContent(59, "<h5>Dinner</h5>\r\n                                    ");
            __builder.AddMarkupContent(60, "<p>17:00 - 20:00</p>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "Table-div");
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.AddMarkupContent(72, "<h4 class>Reservering overzicht</h4>\r\n    <div style=\"border-top: 1px solid; padding-bottom: 33px; margin-left: 11%; width: 76%; color: #E6DBDA;\"></div>\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "h6");
            __builder.AddAttribute(76, "class", "DatED");
            __builder.AddContent(77, 
#nullable restore
#line 54 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                           DateInText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "h6");
            __builder.AddAttribute(80, "class", "DayD");
            __builder.AddContent(81, 
#nullable restore
#line 55 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                          DaypartText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", " card-group");
            __builder.AddAttribute(86, "style", " width: 555px;height:450px;margin-left: 100px;margin-bottom: 36px; ");
            __builder.AddMarkupContent(87, "\r\n\r\n\r\n        ");
            __builder.OpenElement(88, "table");
            __builder.AddAttribute(89, "id", "myTable");
            __builder.AddAttribute(90, "class", "table");
            __builder.AddAttribute(91, "cellspacing", "0");
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 61 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
              

                con.SqlQuery("SELECT reservation.Date, reservation.DayPart, reservation.TableNumber, reservation.Amount, reservation.IsConfirm, guest.FullName, guest.id_Guest, reservation.id_Reservation FROM reservation INNER JOIN guest ON reservation.Guest = guest.id_Guest WHERE reservation.Date = @date AND reservation.DayPart = @Daypart");
                con.Cmd.Parameters.AddWithValue("@date", CreateRes.date);
                con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
                con.QueryEx();

            

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "            ");
            __builder.AddMarkupContent(94, @"<thead>
                <tr>
                    <td class=""HeadDesign"">Naam</td>
                    <td class=""HeadDesign"">Aantal personen </td>
                    <td class=""HeadDesign"">Tafel</td>
                    <td class=""HeadDesign actieTD"">Actie</td>
                </tr>
            </thead>
            ");
            __builder.OpenElement(95, "tbody");
            __builder.AddMarkupContent(96, "\r\n\r\n");
#nullable restore
#line 79 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                 foreach (DataRow dr in con.QueryEx().Rows)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                    ");
            __builder.OpenElement(98, "tr");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "td");
            __builder.AddAttribute(101, "class", "nameTD");
            __builder.AddContent(102, 
#nullable restore
#line 82 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[5].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "class", "AmountD");
            __builder.AddContent(106, 
#nullable restore
#line 83 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                             dr[3].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "class", "TableD");
            __builder.AddContent(110, 
#nullable restore
#line 84 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[2].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "td");
            __builder.AddMarkupContent(113, "\r\n                            ");
            __builder.OpenElement(114, "button");
            __builder.AddAttribute(115, "value", 
#nullable restore
#line 86 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[7].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(116, "class", "BlockButton");
            __builder.AddAttribute(117, "style", " float: left;background-color: #F0F1F7;border: none;border-radius: 10%; width: 36px;height: 28px;margin-right: 13px;");
            __builder.AddMarkupContent(118, "<i class=\"fas fa-window-close\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                            ");
            __builder.OpenElement(120, "button");
            __builder.AddAttribute(121, "value", 
#nullable restore
#line 87 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[6].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(122, "class", "NoshowButton");
            __builder.AddAttribute(123, "style", "float: left;background-color: #F0F1F7;border: none;border-radius: 10%; width: 36px;height: 28px;");
            __builder.AddMarkupContent(124, "<i class=\"fas fa-eye-slash\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 90 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
            __builder.CloseElement();
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
#line 97 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
 

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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
