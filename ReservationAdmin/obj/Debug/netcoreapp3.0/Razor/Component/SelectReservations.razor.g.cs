#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b752826275037f986b68931a5218daa7c4f864a7"
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
using ReservationAdmin.Models;

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
#line 6 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class SelectReservations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "background-color:#D5DAD7; float :left; width: 35%;  height: 100vh;");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.AddMarkupContent(6, "<p style=\"margin-left: 7%; color: #9597A6; font-size: 24px;padding-top: 5px;    margin-bottom: 5px;\">Agenda</p>\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "border-top: 1px solid;padding-bottom: 7px;   margin-left: 2%; width: 95%; ");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "margin-top:30px;");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.AddMarkupContent(13, "<h4>Datum</h4>\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "Form-date");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", " margin-left: 23px;");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n                                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "date");
            __builder.AddAttribute(26, "id", "txtDate");
            __builder.AddAttribute(27, "onkeydown", "return false");
            __builder.AddAttribute(28, "class", "input-group-addon date-div unstyled form-control");
            __builder.AddAttribute(29, "max", "2025-01-1");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                           CreateRes.date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.date = __value, CreateRes.date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-top: 18%;");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<h4>Dagdeel</h4>\r\n                        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "Daypart-div");
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "Daypart");
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,
#nullable restore
#line 33 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                (e => SelectedDaypart(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn Daypart-btn Daypart-btn-lunch");
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.AddMarkupContent(52, "<h5>Lunch</h5>\r\n                                    ");
            __builder.AddMarkupContent(53, "<p>11:00 - 16:00</p>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,
#nullable restore
#line 37 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                (e=> SelectedDaypart(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "class", "btn Daypart-btn   Daypart-btn-diner");
            __builder.AddMarkupContent(59, "\r\n                                    ");
            __builder.AddMarkupContent(60, "<h5>Dinner</h5>\r\n                                    ");
            __builder.AddMarkupContent(61, "<p>17:00 - 20:00</p>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "Table-div");
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.AddMarkupContent(73, "<h4 class>Reservering overzicht</h4>\r\n    <div style=\"border-top: 1px solid; padding-bottom: 33px; margin-left: 11%; width: 76%; color: #E6DBDA;\"></div>\r\n    ");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "h6");
            __builder.AddAttribute(77, "class", "DatED");
            __builder.AddContent(78,
#nullable restore
#line 52 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                           DateInText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "h6");
            __builder.AddAttribute(81, "class", "DayD");
            __builder.AddContent(82,
#nullable restore
#line 53 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                          DaypartText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", " card-group");
            __builder.AddAttribute(87, "style", " width: 555px;height:450px;margin-left: 100px;margin-bottom: 36px; ");
            __builder.AddMarkupContent(88, "\r\n\r\n\r\n        ");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "id", "myTable");
            __builder.AddAttribute(91, "class", "table");
            __builder.AddAttribute(92, "cellspacing", "0");
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 59 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"


                con.SqlQuery("SELECT reservation.Date, reservation.DayPart, reservation.TableNumber, reservation.Amount, reservation.IsConfirm, guest.FullName, guest.id_Guest, reservation.id_Reservation FROM reservation INNER JOIN guest ON reservation.Guest = guest.id_Guest WHERE reservation.Date = @date AND reservation.DayPart = @Daypart");
                con.Cmd.Parameters.AddWithValue("@date", CreateRes.date);
                con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
                con.QueryEx();



#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "            ");
            __builder.OpenElement(95, "thead");
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.AddMarkupContent(99, "<td class=\"HeadDesign\">Naam</td>\r\n                    ");
            __builder.AddMarkupContent(100, "<td class=\"HeadDesign\">Aantal personen </td>\r\n                    ");
            __builder.AddMarkupContent(101, "<td class=\"HeadDesign\">Tafel</td>\r\n");
#nullable restore
#line 73 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                 if (CreateRes.date == DateTime.Today)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                    ");
            __builder.AddMarkupContent(103, "<td class=\"HeadDesign actieTD\">Actie</td>\r\n");
#nullable restore
#line 76 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                ");
            __builder.AddMarkupContent(105, "<td class=\"HeadDesign\">Is bevestigt?</td>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "tbody");
            __builder.AddMarkupContent(109, "\r\n\r\n");
#nullable restore
#line 77 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                 foreach (DataRow dr in con.QueryEx().Rows)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                    ");
            __builder.OpenElement(111, "tr");
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.OpenElement(113, "td");
            __builder.AddAttribute(114, "class", "nameTD");
            __builder.AddContent(115,
#nullable restore
#line 80 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[5].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "td");
            __builder.AddAttribute(118, "class", "AmountD");
            __builder.AddContent(119,
#nullable restore
#line 81 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                             dr[3].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.OpenElement(121, "td");
            __builder.AddAttribute(122, "class", "TableD");
            __builder.AddContent(123,
#nullable restore
#line 82 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[2].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 88 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"


                                string IsConfirmed = dr[4].ToString();


#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                             if (CreateRes.date == DateTime.Today && IsConfirmed == "Ja")
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                                ");
            __builder.OpenElement(126, "td");
            __builder.AddMarkupContent(127, "\r\n                                    ");
            __builder.OpenElement(128, "button");
            __builder.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,
#nullable restore
#line 95 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                      (e => DeleteReservation(dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "class", "BlockButton");
            __builder.AddAttribute(131, "style", " float: left;background-color: #F0F1F7;border: none;border-radius: 10%; width: 36px;height: 28px;margin-right: 13px;");
            __builder.AddMarkupContent(132, "<i class=\"fas fa-window-\"></i>&#10060;");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                                    ");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,
#nullable restore
#line 96 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                      (e => UpdateNoShow(dr[6].ToString(),dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "class", "NoshowButton");
            __builder.AddAttribute(137, "style", "float: left;background-color: #F0F1F7;border: none;border-radius: 10%; width: 36px;height: 28px;");
            __builder.AddMarkupContent(138, "<i class=\"fas fa-eye-slash\">&#xf070;</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 98 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                    }
                            else if (IsConfirmed == "Nee")
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "                                ");
            __builder.OpenElement(142, "td");
            __builder.AddMarkupContent(143, "\r\n                                    ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,
#nullable restore
#line 102 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                      (e => DeleteReservation(dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "class", "BlockButton");
            __builder.AddAttribute(147, "style", " float: left;background-color: #F0F1F7;border: none;border-radius: 10%; width: 36px;height: 28px;");
            __builder.AddMarkupContent(148, "<i class=\"fas fa-window-\"></i>&#10060;");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 104 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.OpenElement(152, "td");
            __builder.AddAttribute(153, "class", "TableD");
            __builder.AddContent(154,
#nullable restore
#line 106 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[4].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 91 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"

    Reservation CreateRes = new Reservation();
    SqlConnection con = new SqlConnection();


#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"


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
