#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fd432f8abaa962404133904e48a3742732860e"
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
#nullable restore
#line 7 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
using Microsoft;

#line default
#line hidden
#nullable disable
    public class SelectReservations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "PartOne");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<p class=\"TitleSubject\">Agenda</p>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "Underline");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "margin-top:30px;");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h4>Datum</h4>\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "Form-date");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", " margin-left: 23px;");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "date");
            __builder.AddAttribute(26, "id", "txtDate");
            __builder.AddAttribute(27, "onkeydown", "return false");
            __builder.AddAttribute(28, "class", "input-group-addon date-div unstyled form-control");
            __builder.AddAttribute(29, "max", "2025-01-1");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                       CreateRes.date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.date = __value, CreateRes.date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-top: 18%;");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddMarkupContent(40, "<h4>Dagdeel</h4>\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "Daypart-div");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "Daypart");
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                            (e => SelectedDaypart(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn Daypart-btn Daypart-btn-lunch");
            __builder.AddMarkupContent(51, "\r\n                                ");
            __builder.AddMarkupContent(52, "<h5>Lunch</h5>\r\n                                ");
            __builder.AddMarkupContent(53, "<p>11:00 - 16:00</p>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                            (e=> SelectedDaypart(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "class", "btn Daypart-btn   Daypart-btn-diner");
            __builder.AddMarkupContent(59, "\r\n                                ");
            __builder.AddMarkupContent(60, "<h5>Dinner</h5>\r\n                                ");
            __builder.AddMarkupContent(61, "<p>17:00 - 20:00</p>\r\n                            ");
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
#line 55 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
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
#line 56 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
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
            __builder.AddAttribute(87, "style", " width: 600px;height:450px;margin-left: 100px;margin-bottom: 36px; ");
            __builder.AddMarkupContent(88, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "id", "myTable");
            __builder.AddAttribute(91, "class", "table");
            __builder.AddAttribute(92, "cellspacing", "0");
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 62 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
              
                con.SqlQuery("SELECT reservation.Date, reservation.DayPart, reservation.TableNumber, reservation.Amount, reservation.IsConfirm, guest.FullName, guest.id_Guest, reservation.id_Reservation FROM reservation INNER JOIN guest ON reservation.Guest = guest.id_Guest WHERE reservation.Date = @date AND reservation.DayPart = @Daypart");
                con.Cmd.Parameters.AddWithValue("@date", CreateRes.date);
                con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
                con.QueryEx();
                bool TableHeader = true;
                string IsConfirmed = "Nee";
                bool ActionVisible = false;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
             foreach (DataRow dr in con.QueryEx().Rows)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                 if (TableHeader)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "                    ");
            __builder.OpenElement(95, "thead");
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.AddMarkupContent(99, "<td class=\"HeadDesign\">Naam</td>\r\n                            ");
            __builder.AddMarkupContent(100, "<td class=\"HeadDesign\">Aantal personen </td>\r\n                            ");
            __builder.AddMarkupContent(101, "<td class=\"HeadDesign\">Tafel</td>\r\n");
#nullable restore
#line 80 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                              
                                bool isFound = false;
                                //kijk of er een knop in de rijen eronder aanwezig is om "Actie" aan de kolomnamen toe te voegen
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                             foreach (DataRow dr1 in con.QueryEx().Rows)
                            {
                                IsConfirmed = dr1[4].ToString();
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                 if (isFound == false)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                     if (CreateRes.date >= DateTime.Today)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                                        ");
            __builder.AddMarkupContent(103, "<td class=\"HeadDesign actieTD\">Actie</td>\r\n");
#nullable restore
#line 92 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                        isFound = true;
                                        ActionVisible = true;
                                    }
                                    else if (IsConfirmed == "Nee")
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                                        ");
            __builder.AddMarkupContent(105, "<td class=\"HeadDesign actieTD\">Actie</td>\r\n");
#nullable restore
#line 98 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                        isFound = true;
                                        ActionVisible = true;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                            ");
            __builder.AddMarkupContent(107, "<td class=\"HeadDesign\">Is bevestigd?</td>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 106 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                    TableHeader = false;
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                ");
            __builder.OpenElement(111, "tbody");
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.OpenElement(113, "tr");
            __builder.AddMarkupContent(114, "\r\n                        \r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "class", "nameTD");
            __builder.AddContent(117, 
#nullable restore
#line 111 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[5].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "class", "AmountD");
            __builder.AddContent(121, 
#nullable restore
#line 112 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                             dr[3].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "class", "TableD");
            __builder.AddContent(125, 
#nullable restore
#line 113 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[2].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 114 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                          
                            IsConfirmed = dr[4].ToString();
                            //kijk of er de reservering vandaag is om de "noshow" knop aan te zetten 
                            //kijk of de reservering bevestigd is om de verwijder knop
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                         if (CreateRes.date == DateTime.Today && IsConfirmed == "Ja")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                            ");
            __builder.OpenElement(128, "td");
            __builder.AddMarkupContent(129, "\r\n                                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "style", "float: left;");
            __builder.AddMarkupContent(132, "\r\n                                    ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "title", "Verwijder reservering");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                                    (e => DeleteReservation(dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "class", "BlockButton");
            __builder.AddAttribute(137, "style", "float: left; background-color: #F0F1F7; border: none; border-radius: 10%; width: 36px; height: 28px;");
            __builder.AddMarkupContent(138, "<i class=\"fas fa-window-\"></i>&#10060;");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                                ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "style", "float: left");
            __builder.AddMarkupContent(143, "\r\n                                    ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "title", "No-show");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                      (e => UpdateNoShow(dr[6].ToString(), dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "class", "NoshowButton");
            __builder.AddAttribute(148, "style", "float: left; background-color: #F0F1F7; border: none; border-radius: 10%; width: 36px; height: 28px;");
            __builder.AddMarkupContent(149, "<i class=\"fa\">&#xf070;</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 129 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                        }
                        else if (CreateRes.date >= DateTime.Today || IsConfirmed == "Nee")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                            ");
            __builder.OpenElement(154, "td");
            __builder.AddMarkupContent(155, "\r\n                                ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "style", "float: left;");
            __builder.AddMarkupContent(158, "\r\n                                    ");
            __builder.OpenElement(159, "button");
            __builder.AddAttribute(160, "title", "Verwijder reservering");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 134 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                                                                    (e => DeleteReservation(dr[7].ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "class", "BlockButton");
            __builder.AddAttribute(163, "style", "float: left; background-color: #F0F1F7; border: none; border-radius: 10%; width: 36px; height: 28px;");
            __builder.AddMarkupContent(164, "<i class=\"fas fa-window-\"></i>&#10060;");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n");
#nullable restore
#line 137 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                        }
                        else if (ActionVisible)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(168, "                            <td></td>\r\n");
#nullable restore
#line 141 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(169, "\r\n                        ");
            __builder.OpenElement(170, "td");
            __builder.AddAttribute(171, "class", "TableD");
            __builder.AddContent(172, 
#nullable restore
#line 143 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                                            dr[4].ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n");
#nullable restore
#line 147 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
                
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(176, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
       
    Reservation CreateRes = new Reservation();
    SqlConnection con = new SqlConnection();


#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\SelectReservations.razor"
 
    Guest InfoGuest = new Guest();
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
        sendMail(ReservationID);
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
    //blokkeer iedereen die 3 keer niet is geweest
    void UpdatedIsBlocked()
    {
        con.SqlQuery("UPDATE guest SET IsBlocked = 1 where NoShow = 3");
        con.QueryEx();
    }
    //stuur een mail naar de klant om te laten weten dat hun reservering geannuleerd is
    void sendMail(string ReservationID)
    {
        con.SqlQuery("SELECT  guest.`Email` FROM `reservation` INNER JOIN guest ON reservation.Guest = guest.id_Guest  WHERE `id_Reservation`=@ReservationID");
        con.Cmd.Parameters.AddWithValue("@ReservationID",ReservationID);
        con.QueryEx();

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            InfoGuest.Email = dr[0].ToString();
        }

        string messageone = "Dit is een bevestiging dat u de reservering heeft geannuleerd.";
        string EndMail = "Hopelijk komt u weer bij ons reserveren";
        string htmlBody = @"<html lang=""en"">
                        <head>
                            <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"">
                            <title>
                                Upcoming topics
                            </title>
                            <style type=""text/css"">
                                HTML{background-color: #e8e8e8;}
                                .message{background-color: #ffff; font-weight: 400;  font-size: 16px; padding: 2% 18% 4% 18%;}
                                .courses-table{font-size: 12px; padding: 3px; border:0; cellspacing:0; cellpadding:0; border-spacing: 0;}
                                .TitleMessage{ padding-left: 29%; font-size: 33px; color: #354052;}
                                .courses-table th{color: #354052;text-align: left; padding: 1% 1%;}
                                .side-Right-Left{background-color: #F3F3F3; padding: 0 1%;}
                                .BacKColor{background-color: #F3F3F3;}
                                .EndMessage{ background-color: #F3F3F3; color: #354052; font-size: 25px;   padding-left: 32%;  padding-right: 36%;  font-weight: 700;  text-align: center;}
                            </style>
                        </head>
                        <body>
                            <table class=""courses-table"">
                                <thead>
                                    <tr>
                                        <th class=""BacKColor""></th>
                                        <th class=""BacKColor""></th>
                                        <th class=""BacKColor""></th>

                                    </tr>
                                </thead>
                                <tbody>
                                <tr>
                                  <td class=BacKColor></td>
                                  <td class=TitleMessage>Uw reservering is geannuleerd</td>
                                  <td class=BacKColor></td>
                              </tr>
                                    <tr>
                                        <td class=""side-Right-Left""><td class=""message"">" + messageone + "</td><td class=side-Right-Left> </td> </td> " +
                                          "</tr> " +
                                       "</tbody> " +
                                 " <tfoot> " +
                                    "<tr>" +
                                      " <td class=BacKColor></td>" +
                                      " <td class=EndMessage>" + EndMail + "</td>" +
                                      " <td class=BacKColor></td>" +
                                   " </tr> " +
                                 "</tfoot>" +
                                "</body> " +
                              "</html>";



        string subject = "Annulering resevering";
        MailMessage mailMessage = new MailMessage("reserveringsysteem2@gmail.com", InfoGuest.Email, subject, htmlBody);
        mailMessage.IsBodyHtml = true;

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        smtpClient.Port = 587;
        smtpClient.Credentials = new System.Net.NetworkCredential("reserveringsysteem2@gmail.com", "TestRes1!@");
        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
