#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d70bcbcb09a4b2b9e1c4d517914e97bb880588b"
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
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using ReservationAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class ReservationCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "background-color:#D5DAD7; float :left; width: 35%;  height: 100vh;");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<p style=\"margin-left: 7%; color: #9597A6; font-size: 24px;padding-top: 5px;    margin-bottom: 5px;\">Aanmaken reservering</p>\r\n\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "border-top: 1px solid;padding-bottom: 7px;   margin-left: 2%; width: 95%; ");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<h4>Gegevens</h4>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "padding: 30px; background-color: #ffffff;");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-inline  form-group");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<label for=\"Name\">Volledig naam</label>\r\n\r\n                    ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-controls");
            __builder.AddAttribute(20, "aria-describedby", "FullName");
            __builder.AddAttribute(21, "placeholder", "Volledige naam");
            __builder.AddAttribute(22, "required", true);
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                                    CreateRes.FullName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.FullName = __value, CreateRes.FullName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-inline form-group ");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.AddMarkupContent(30, "<label for=\"Email\" style=\"margin-right:10%;\">Email      </label>\r\n                    ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "email");
            __builder.AddAttribute(33, "class", "form-controls");
            __builder.AddAttribute(34, "aria-describedby", "emailHelp");
            __builder.AddAttribute(35, "placeholder", "Email adres");
            __builder.AddAttribute(36, "required", true);
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                                     CreateRes.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.Email = __value, CreateRes.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-inline  form-group");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddMarkupContent(44, "<label for=\"InputAmount\">Aantal personen</label>\r\n                    ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "number");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "aria-describedby", "Amount");
            __builder.AddAttribute(49, "placeholder", "6");
            __builder.AddAttribute(50, "min", "1");
            __builder.AddAttribute(51, "max", "6");
            __builder.AddAttribute(52, "required", true);
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                                     CreateRes.Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CreateRes.Amount = __value, CreateRes.Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.AddMarkupContent(60, "<h4>Dagdeel</h4>\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "Daypart-div");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "Daypart");
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedDaypart(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "class", "btn Daypart-btn Daypart-btn-lunch");
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.AddMarkupContent(72, "<h5>Lunch</h5>\r\n                            ");
            __builder.AddMarkupContent(73, "<p>11:00 - 16:00</p>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e=> SelectedDaypart(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "class", "btn Daypart-btn   Daypart-btn-diner");
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.AddMarkupContent(80, "<h5>Dinner</h5>\r\n                            ");
            __builder.AddMarkupContent(81, "<p>17:00 - 20:00</p>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n    ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "type", "submit");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                    CheckDoubleUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", " btn-ResAdmin btn btn-primary");
            __builder.AddMarkupContent(92, "\r\n        Reserveren\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "Table-div");
            __builder.AddMarkupContent(97, "\r\n\r\n    ");
            __builder.AddMarkupContent(98, "<h1>Tafel kiezen</h1>\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "Tafel   card-group");
            __builder.AddAttribute(101, "style", " background-image: url(\'images/tafel-van-zes.png\');  width:500px; height:450px; margin-left: 69px; margin-bottom: 36px; ");
            __builder.AddMarkupContent(102, "\r\n\r\n        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "style", " margin-left:21%; margin-top: 7%;");
            __builder.AddMarkupContent(105, "\r\n\r\n            ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "id", "Table1");
            __builder.AddAttribute(108, "type", "button");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(1))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(111, "class", "Tafel TableWitFour btn btn-primary");
            __builder.AddMarkupContent(112, "\r\n                1\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n            ");
            __builder.OpenElement(114, "button");
            __builder.AddAttribute(115, "id", "Table2");
            __builder.AddAttribute(116, "type", "button");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(2))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(119, "class", "Tafel  TableWitFour btn btn-primary");
            __builder.AddMarkupContent(120, "\r\n                2\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.OpenElement(122, "button");
            __builder.AddAttribute(123, "id", "Table3");
            __builder.AddAttribute(124, "type", "button");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(3))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "style", "width: 47px;\r\n        height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(127, "class", "Tafel TableWitFour btn btn-primary");
            __builder.AddMarkupContent(128, "\r\n                3\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n        ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "style", "margin-top: 7%;");
            __builder.AddMarkupContent(133, "\r\n            ");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "id", "Table4");
            __builder.AddAttribute(136, "type", "button");
            __builder.AddAttribute(137, "class", "Tafel TableWitSix  btn btn-primary");
            __builder.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                                                                   (e => SelectedTable(4))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "style", "width: 47px; height: 87px; margin-left: 27px; margin-right: 40px; margin-top: 15px;");
            __builder.AddMarkupContent(140, "\r\n                4\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n        ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "style", "padding-left: 50%;height: 7%; margin-top: -3%;");
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "id", "Table5");
            __builder.AddAttribute(148, "type", "button");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(5))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "style", "width: 30px; height: 35px; margin-right:48px;");
            __builder.AddAttribute(151, "class", "Tafel TableWitTwo btn btn-primary");
            __builder.AddContent(152, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.OpenElement(154, "button");
            __builder.AddAttribute(155, "id", "Table6");
            __builder.AddAttribute(156, "type", "button");
            __builder.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(6))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "style", "width: 30px; height: 35px; ");
            __builder.AddAttribute(159, "class", "Tafel TableWitTwo  btn btn-primary");
            __builder.AddContent(160, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n\r\n        ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "style", "width: 27%; margin-left: 1%;margin-bottom: 24%;  margin-top: 3%;");
            __builder.AddMarkupContent(165, "\r\n            ");
            __builder.OpenElement(166, "button");
            __builder.AddAttribute(167, "id", "Table8");
            __builder.AddAttribute(168, "type", "button");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(8))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "style", "width: 58px;  height: 48px; margin-left: 25px;  margin-right: 33px;  margin-top: 17%;");
            __builder.AddAttribute(171, "class", " Tafel TableWitFour btn btn-primary");
            __builder.AddMarkupContent(172, "\r\n                8\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n            ");
            __builder.OpenElement(174, "button");
            __builder.AddAttribute(175, "id", "Table10");
            __builder.AddAttribute(176, "type", "button");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                         (e => SelectedTable(10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(178, "style", "width: 58px;  height: 48px;  margin-left: 25px;  margin-right: 33px;  margin-top: 31%;");
            __builder.AddAttribute(179, "class", " Tafel TableWitFour btn btn-primary");
            __builder.AddMarkupContent(180, "\r\n                10\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n            ");
            __builder.OpenElement(182, "button");
            __builder.AddAttribute(183, "id", "Table11");
            __builder.AddAttribute(184, "type", "button");
            __builder.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                         (e => SelectedTable(11))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(186, "style", " width: 90px; height: 48px; margin-left: 25px; margin-right: 33px;   margin-top: 34%;");
            __builder.AddAttribute(187, "class", "Tafel TableWitSix  btn btn-primary");
            __builder.AddMarkupContent(188, "\r\n                11\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n        ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "style", "  width: 19%; margin-left: 1%; ");
            __builder.AddMarkupContent(193, "\r\n            ");
            __builder.OpenElement(194, "button");
            __builder.AddAttribute(195, "id", "Table7");
            __builder.AddAttribute(196, "type", "button");
            __builder.AddAttribute(197, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(7))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(198, "style", "width: 58px;height: 46px; margin-left: 7px;margin-right: 6px; margin-top: 20%;");
            __builder.AddAttribute(199, "class", "Tafel TableWitFour btn btn-primary");
            __builder.AddMarkupContent(200, "\r\n                7\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n            ");
            __builder.OpenElement(202, "button");
            __builder.AddAttribute(203, "id", "Table9");
            __builder.AddAttribute(204, "type", "button");
            __builder.AddAttribute(205, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
                                                        (e => SelectedTable(9))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(206, "style", " width: 59px; height: 45px; margin-left: 7px; margin-right: 33px;  margin-top: 55%;");
            __builder.AddAttribute(207, "class", "Tafel TableWitFour  btn btn-primary");
            __builder.AddMarkupContent(208, "\r\n                9\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
      








    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();

    //Check of mail correct is anders stuurt de
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


    //Pak de waarde van geselecteerd tafel

    void SelectedTable(int SelectedTable)
    {
        CreateRes.Table = SelectedTable;
        Message = "Tafel Nummer gekozen" + CreateRes.Table.ToString();
        Debug.WriteLine(Message);


    }
    //Pak de waarde van geselecteerd dagdeel
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
        Message = "daypart  gekozen" + CreateRes.Daypart.ToString();
        Debug.WriteLine(Message);

        if (CreateRes.Amount == 6)
        {
            LessThenSix();

        }
    }
    async Task LessThenSix()
    {
        await JsRuntime.InvokeVoidAsync("Disabled");

    }

    void CheckDoubleUser()
    {

        con.SqlQuery("SELECT `id_Guest` FROM `guest` WHERE `FullName`=@Fullname AND `Email`=@Email");
        con.Cmd.Parameters.AddWithValue("@Fullname", CreateRes.FullName);
        con.Cmd.Parameters.AddWithValue("@Email", CreateRes.Email);

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            CreateRes.id = Convert.ToInt32(dr[0].ToString());
        }

        if (CreateRes.id == 0)
        {
            InsertUser();

        }
        else
        {
            InsertReservation();

        }

    }
    //Zet Gast neer in database
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
    //Zet Gast neer in database
    void InsertReservation()
    {


        con.SqlQuery("INSERT INTO `reservation`(`Date`, `DayPart`, `TableNumber`, `Guest`, `Amount`) VALUES (@Date,@Daypart,@TableNumber,@Guest,@Amount)");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date);
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
        con.Cmd.Parameters.AddWithValue("@Guest", CreateRes.id);
        con.Cmd.Parameters.AddWithValue("@Amount", CreateRes.Amount);
        con.NonQueryEx();


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591