#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d93697c07b5066e58ccc89c3025fdd438319fa"
// <auto-generated/>
#pragma warning disable 1591
namespace ReservationGuest.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using ReservationGuest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "id", "form1");
            __builder.AddAttribute(2, "runat", "server");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "div1");
            __builder.AddAttribute(6, "class", "divs");
            __builder.AddAttribute(7, "style", "background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<h1>Gegevens</h1>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "padding: 30px; background-color: #ffffff;");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-inline  form-group");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<label for=\"Name\">Volledig naam</label>\r\n\r\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-controls");
            __builder.AddAttribute(20, "aria-describedby", "FullName");
            __builder.AddAttribute(21, "placeholder", "Volledige naam");
            __builder.AddAttribute(22, "required", true);
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                CreateRes.FullName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.FullName = __value, CreateRes.FullName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-inline form-group ");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<label for=\"Email\" style=\"margin-right:10%;\">Email      </label>\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "email");
            __builder.AddAttribute(33, "class", "form-controls");
            __builder.AddAttribute(34, "aria-describedby", "emailHelp");
            __builder.AddAttribute(35, "placeholder", "Email adres");
            __builder.AddAttribute(36, "required", true);
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                 CreateRes.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.Email = __value, CreateRes.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-inline  form-group");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label for=\"InputAmount\">Aantal personen</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "number");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "aria-describedby", "Amount");
            __builder.AddAttribute(49, "placeholder", "0");
            __builder.AddAttribute(50, "min", "1");
            __builder.AddAttribute(51, "max", "6");
            __builder.AddAttribute(52, "required", true);
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                 CreateRes.Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.Amount = __value, CreateRes.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "id", "2");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "value", "volgende");
            __builder.AddAttribute(62, "class", "buttons btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                                               NextDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "style", "float:right");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(68, "form");
            __builder.AddAttribute(69, "method", "post");
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "id", "div2");
            __builder.AddAttribute(73, "class", "divs CHidden");
            __builder.AddAttribute(74, "style", "background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.AddMarkupContent(76, "<h1>Datum</h1>\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "style", " margin-left: 23px;");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.AddMarkupContent(80, @"<div>
                <div>
                    Selected Date: <span id=""selected-date""></span>
                    <br>
                    <br>Value of hidden field: <span id=""hidden-val""></span>
                    <br>
                </div>
                <div class=""col-lg-8 datepicker_area"" style=""background: red;"">
                    <div style=""overflow:hidden;"">
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-md-8 WHY"">q
                                    <div id=""datetimepicker"" data-date=""12/03/2012 12:00 PM""></div>
                                    <input type=""hidden"" name=""date"" id=""my_hidden_input"" value>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div id=""datetimepicker"" data-date=""12/03/2012 12:00 PM"">
                        <input type=""hidden"" name=""date"" id=""my_hidden_input"" value>
                    </div>
                </div>
            </div>
          ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                           NextDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "id", "3");
            __builder.AddAttribute(84, "type", "button");
            __builder.AddAttribute(85, "value", "volgende");
            __builder.AddAttribute(86, "class", "buttons btn btn-primary");
            __builder.AddAttribute(87, "style", "float:right");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n");
            __builder.OpenElement(92, "form");
            __builder.AddAttribute(93, "method", "post");
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "id", "div3");
            __builder.AddAttribute(97, "class", "divs CHidden");
            __builder.AddAttribute(98, "style", "background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;");
            __builder.AddMarkupContent(99, "\r\n\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "Daypart-div");
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.AddMarkupContent(103, "<h4>Dagdeel</h4>\r\n            ");
            __builder.OpenElement(104, "div");
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "Daypart");
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "type", "button");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                    (e => SelectedDaypart(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "class", "btn Daypart-btn Daypart-btn-lunch");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.AddMarkupContent(114, "<h5>Lunch</h5>\r\n                        ");
            __builder.AddMarkupContent(115, "<p>11:00 - 16:00</p>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "type", "button");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                    (e => SelectedDaypart(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "class", "btn Daypart-btn   Daypart-btn-diner");
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.AddMarkupContent(122, "<h5>Diner</h5>\r\n                        ");
            __builder.AddMarkupContent(123, "<p>17:00 - 20:00</p>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\r\n                ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "id", "3");
            __builder.AddAttribute(128, "type", "button");
            __builder.AddAttribute(129, "value", "volgende");
            __builder.AddAttribute(130, "class", "buttons btn btn-primary");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                                                       NextDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "style", "float:right");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
            __builder.OpenElement(138, "form");
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "id", "div4");
            __builder.AddAttribute(142, "class", "divs CHidden TableGroupDIV");
            __builder.AddMarkupContent(143, "\r\n        ");
            __builder.AddMarkupContent(144, "<h1>Tafel kiezen</h1>\r\n        ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "Tafel   card-group");
            __builder.AddAttribute(147, "style", " background-image: url(\'images/tafel-van-zes.png\');  width:500px; height:450px; margin-left: 69px;\r\n        margin-bottom: 36px; ");
            __builder.AddMarkupContent(148, "\r\n\r\n            ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "style", " margin-left:21%; margin-top: 7%;");
            __builder.AddMarkupContent(151, "\r\n\r\n                ");
            __builder.OpenElement(152, "button");
            __builder.AddAttribute(153, "type", "button");
            __builder.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(1))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(155, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(156, "class", "Tafel tafels btn btn-primary");
            __builder.AddMarkupContent(157, "\r\n                    1\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n\r\n                ");
            __builder.OpenElement(159, "button");
            __builder.AddAttribute(160, "type", "button");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(2))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(163, "class", "Tafel btn btn-primary");
            __builder.AddMarkupContent(164, "\r\n                    2\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.OpenElement(166, "button");
            __builder.AddAttribute(167, "type", "button");
            __builder.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(3))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(170, "class", "Tafel btn btn-primary");
            __builder.AddMarkupContent(171, "\r\n                    3\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n\r\n            ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "style", "margin-top: 7%;");
            __builder.AddMarkupContent(176, "\r\n                ");
            __builder.OpenElement(177, "button");
            __builder.AddAttribute(178, "type", "button");
            __builder.AddAttribute(179, "class", "Tafel  btn btn-primary");
            __builder.AddAttribute(180, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 119 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                               (e => SelectedTable(4))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(181, "style", "width: 47px; height: 87px; margin-left: 27px; margin-right: 40px; margin-top: 15px;");
            __builder.AddMarkupContent(182, "\r\n                    4\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n\r\n            ");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "style", "padding-left: 50%;height: 7%; margin-top: -3%;");
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "type", "button");
            __builder.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(5))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "style", "width: 30px; height: 35px; margin-right:48px;");
            __builder.AddAttribute(192, "class", " Tafel btn btn-primary");
            __builder.AddContent(193, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                ");
            __builder.OpenElement(195, "button");
            __builder.AddAttribute(196, "type", "button");
            __builder.AddAttribute(197, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(6))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(198, "style", "width: 30px; height: 35px; ");
            __builder.AddAttribute(199, "class", " Tafel btn btn-primary");
            __builder.AddContent(200, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n\r\n            ");
            __builder.OpenElement(203, "div");
            __builder.AddAttribute(204, "style", "width: 27%; margin-left: 1%;margin-bottom: 24%;  margin-top: 3%;");
            __builder.AddMarkupContent(205, "\r\n                ");
            __builder.OpenElement(206, "button");
            __builder.AddAttribute(207, "type", "button");
            __builder.AddAttribute(208, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(8))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(209, "style", "width: 58px;  height: 48px; margin-left: 25px;  margin-right: 33px;  margin-top: 17%;");
            __builder.AddAttribute(210, "class", " Tafel btn btn-primary");
            __builder.AddMarkupContent(211, "\r\n                    8\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n                ");
            __builder.OpenElement(213, "button");
            __builder.AddAttribute(214, "type", "button");
            __builder.AddAttribute(215, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(216, "style", "width: 58px;  height: 48px;  margin-left: 25px;  margin-right: 33px;  margin-top: 31%;");
            __builder.AddAttribute(217, "class", " Tafel btn btn-primary");
            __builder.AddMarkupContent(218, "\r\n                    10\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                ");
            __builder.OpenElement(220, "button");
            __builder.AddAttribute(221, "type", "button");
            __builder.AddAttribute(222, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(11))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(223, "style", " width: 90px; height: 48px; margin-left: 25px; margin-right: 33px;   margin-top: 34%;");
            __builder.AddAttribute(224, "class", "Tafel  btn btn-primary");
            __builder.AddMarkupContent(225, "\r\n                    11\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "\r\n            ");
            __builder.OpenElement(228, "div");
            __builder.AddAttribute(229, "style", "  width: 19%; margin-left: 1%; ");
            __builder.AddMarkupContent(230, "\r\n                ");
            __builder.OpenElement(231, "button");
            __builder.AddAttribute(232, "type", "button");
            __builder.AddAttribute(233, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(7))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(234, "style", "width: 58px;height: 46px; margin-left: 7px;margin-right: 6px; margin-top: 20%;");
            __builder.AddAttribute(235, "class", "Tafel btn btn-primary");
            __builder.AddMarkupContent(236, "\r\n                    7\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n                ");
            __builder.OpenElement(238, "button");
            __builder.AddAttribute(239, "type", "button");
            __builder.AddAttribute(240, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 144 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                (e => SelectedTable(9))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(241, "style", " width: 59px; height: 45px; margin-left: 7px; margin-right: 33px;  margin-top: 55%;");
            __builder.AddAttribute(242, "class", "Tafel btn btn-primary");
            __builder.AddMarkupContent(243, "\r\n                    9\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(244, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(245, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\r\n        ");
            __builder.OpenElement(247, "input");
            __builder.AddAttribute(248, "id", "3");
            __builder.AddAttribute(249, "type", "button");
            __builder.AddAttribute(250, "value", "volgende");
            __builder.AddAttribute(251, "class", "buttons btn btn-primary");
            __builder.AddAttribute(252, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                                                               NextDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(253, "style", "float:right");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(255, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(256, "\r\n");
            __builder.OpenElement(257, "form");
            __builder.AddMarkupContent(258, "\r\n    ");
            __builder.OpenElement(259, "div");
            __builder.AddAttribute(260, "id", "div5");
            __builder.AddAttribute(261, "class", "divs CHidden");
            __builder.AddMarkupContent(262, "\r\n\r\n        ");
            __builder.OpenElement(263, "div");
            __builder.AddAttribute(264, "style", "background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;");
            __builder.AddMarkupContent(265, "\r\n            ");
            __builder.AddMarkupContent(266, "<h1> Overzicht</h1>\r\n            ");
            __builder.OpenElement(267, "div");
            __builder.AddAttribute(268, "class", "form-inline  form-group");
            __builder.AddMarkupContent(269, "\r\n                ");
            __builder.AddMarkupContent(270, "<label for=\"Datum\">Datum</label>\r\n\r\n                ");
            __builder.OpenElement(271, "label");
            __builder.AddAttribute(272, "class", "form-controls");
            __builder.AddContent(273, 
#nullable restore
#line 161 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                              CreateRes.date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(274, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(275, "\r\n            ");
            __builder.OpenElement(276, "div");
            __builder.AddAttribute(277, "class", "form-inline form-group ");
            __builder.AddMarkupContent(278, "\r\n                ");
            __builder.AddMarkupContent(279, "<label for=\"Dagdeel\">Dagdeel</label>\r\n\r\n                ");
            __builder.OpenElement(280, "label");
            __builder.AddAttribute(281, "class", "form-controls");
            __builder.AddContent(282, 
#nullable restore
#line 166 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                              CreateRes.Daypart

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(283, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(284, "\r\n            ");
            __builder.OpenElement(285, "div");
            __builder.AddAttribute(286, "class", "form-inline form-group ");
            __builder.AddMarkupContent(287, "\r\n                ");
            __builder.AddMarkupContent(288, "<label for=\"Dagdeel\">Naam</label>\r\n\r\n                ");
            __builder.OpenElement(289, "label");
            __builder.AddAttribute(290, "class", "form-controls");
            __builder.AddContent(291, 
#nullable restore
#line 171 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                              CreateRes.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(292, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(293, "\r\n            ");
            __builder.OpenElement(294, "div");
            __builder.AddAttribute(295, "class", "form-inline form-group ");
            __builder.AddMarkupContent(296, "\r\n                ");
            __builder.AddMarkupContent(297, "<label for=\"Dagdeel\">E-mail</label>\r\n\r\n                ");
            __builder.OpenElement(298, "labels");
            __builder.AddAttribute(299, "class", "form-controls");
            __builder.AddContent(300, 
#nullable restore
#line 176 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                                CreateRes.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(301, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(302, "\r\n            ");
            __builder.OpenElement(303, "div");
            __builder.AddAttribute(304, "class", "form-inline form-group ");
            __builder.AddMarkupContent(305, "\r\n                ");
            __builder.AddMarkupContent(306, "<label for=\"Dagdeel\">Aantal personen</label>\r\n\r\n                ");
            __builder.OpenElement(307, "label");
            __builder.AddAttribute(308, "class", "form-controls");
            __builder.AddContent(309, 
#nullable restore
#line 181 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                              CreateRes.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(310, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(311, "\r\n            ");
            __builder.OpenElement(312, "div");
            __builder.AddAttribute(313, "class", "form-inline form-group ");
            __builder.AddMarkupContent(314, "\r\n                ");
            __builder.AddMarkupContent(315, "<label for=\"Dagdeel\">Tafel</label>\r\n\r\n                ");
            __builder.OpenElement(316, "label");
            __builder.AddAttribute(317, "class", "form-controls");
            __builder.AddContent(318, 
#nullable restore
#line 186 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
                                              CreateRes.Table

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(319, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(320, "\r\n\r\n\r\n\r\n            ");
            __builder.AddMarkupContent(321, "<button type=\"submit\" class=\"btn btn-primary\" style=\"float:left\">\r\n                <a href=\"/Datum\">terug</a>\r\n            </button>\r\n\r\n            ");
            __builder.AddMarkupContent(322, "<button type=\"submit\" class=\"btn btn-primary\" style=\"float:right\">\r\n                Reservering\r\n            </button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(323, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(324, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
      

    async Task NextDiv()
    {
        if (IsValidEmail(CreateRes.Email) != false)
        {
            await JsRuntime.InvokeVoidAsync("NextDiv");
        }
        
        
  
    }


    public int i;
    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();
    void SelectedTable(int SelectedTable)
    {
        CreateRes.Table = SelectedTable;
        Message = "Tafel Nummer gekozen" + CreateRes.Table.ToString();
        Debug.WriteLine(Message);


    }
    void SelectedDaypart(bool SelectedDaypart)
    {
        if (SelectedDaypart == false)
        {
            CreateRes.Daypart = "lunch";
        }
        else
        {
            CreateRes.Daypart = "diner";
        }
        Message = "daypart  gekozen" + CreateRes.Daypart.ToString();
        Debug.WriteLine(Message);
    }


    bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
    void InsertUser()
    {
        


        if (IsValidEmail(CreateRes.Email) != false)
        {
            con.SqlQuery("INSERT INTO `guest`(`FullName`, `Email`) VALUES (@Fullname,@Email)");
            con.Cmd.Parameters.AddWithValue("@Fullname", CreateRes.FullName);
            con.Cmd.Parameters.AddWithValue("@Email", CreateRes.Email);
            con.NonQueryEx();
            InsertReservation();
        }
    }

    void InsertReservation()
    {
        con.SqlQuery("SELECT `id_Guest` FROM `guest` WHERE `FullName`=@Fullname AND `Email`=@Email");
        con.Cmd.Parameters.AddWithValue("@Fullname", CreateRes.FullName);
        con.Cmd.Parameters.AddWithValue("@Email", CreateRes.Email);
        con.QueryEx();

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            string id = dr[0].ToString();

            con.SqlQuery("INSERT INTO `reservation`(`Date`, `DayPart`, `TableNumber`, `Guest`, `Amount`) VALUES (@Date,@Daypart,@TableNumber,@Guest,@Amount)");
            con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date);
            con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
            con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
            con.Cmd.Parameters.AddWithValue("@Guest", id);
            con.Cmd.Parameters.AddWithValue("@Amount", CreateRes.Amount);
            con.NonQueryEx();

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
