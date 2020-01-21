#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b95662c183a50161d4bd78336bded9454817ea2"
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
#line 5 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class ReservationCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
      


        SqlConnection con = new SqlConnection();
            public string Message;
    Reservation CreateRes = new Reservation();
    Guest CreateGuest = new Guest();
    public int TableNummerReserved;

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

    void AmountChange(ChangeEventArgs e )
    {

        CreateRes.Amount = Convert.ToInt32(e.Value);
        CreateRes.Table = 0;
        CreateRes.Daypart = "";
        TablesReset("HideTable");
    }





    //Tafels worden weer naar standaard gezet
    async Task TablesReset(string subject)
    {
        if (subject == "HideTable")
        {
            await JsRuntime.InvokeVoidAsync("HideTables");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("ResetTables");

        }

    }

    //Kijkt naar welke tafel geblokkeerd moet worden voor het aantal personen
    async Task LessThenSixFourOrTwo()
    {
        await JsRuntime.InvokeVoidAsync("Disabled", CreateRes.Amount);
    }

    //Gereserveerd Tafel
    async Task DisabledReserved(int Tableres)
    {
        await JsRuntime.InvokeVoidAsync("DisabledReserved", Tableres);
    }

    //Check welke datum het is voor tafelindeling
    async Task CheckWhichDate()
    {

        await JsRuntime.InvokeVoidAsync("WhichDate", CreateRes.date.ToString("yyyy-MM-dd"));

    }

      async Task HolDayPart()
    {

        await JsRuntime.InvokeVoidAsync("HoldValue", CreateRes.Daypart);

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

        HolDayPart();
        
        if (CreateRes.Amount != 0)
        {
            CheckWhichDate();
            TablesReset("Everthing");
            ReserveTable();
            LessThenSixFourOrTwo();
        }
    }

    // Kijkt of de terug of volgende knop is gedrukt
    async Task GetMessage(string subject)
    {

        await JsRuntime.InvokeVoidAsync("Message", subject);
    }

    //Checkt naar gereserveerde tafels
    void ReserveTable()
    {
        con.SqlQuery("SELECT `TableNumber` FROM `reservation` WHERE `Date`=@Date  AND `DayPart`=@Daypart");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date.ToString("yyyy-MM-dd"));
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        foreach (DataRow dr in con.QueryEx().Rows)
        {
            TableNummerReserved = Convert.ToInt32(dr[0].ToString());
            DisabledReserved(TableNummerReserved);
        }
    }

    //Check naar dubble gast gegevens
    void CheckDoubleUser()
    {
        con.SqlQuery("SELECT `id_Guest` FROM `guest` WHERE `FullName`=@Fullname AND `Email`=@Email");
        con.Cmd.Parameters.AddWithValue("@Fullname", CreateGuest.FullName);
        con.Cmd.Parameters.AddWithValue("@Email", CreateGuest.Email);

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            CreateGuest.id = Convert.ToInt32(dr[0].ToString());
        }

        if (CreateGuest.id == 0)
        {
            InsertUser();

        }
        else
        {
            InsertReservation();

        }

    }

    //Kijkt of veld wel gevuld of gekozen zijn en verder kan naar volgende form
    void CheckBlockedOrNotFilled()
    {
        if (CreateGuest.FullName == null || CreateRes.Amount == 0 || CreateGuest.FullName == "" || CreateRes.Table == 0)
        {
            GetMessage("Chosen");
        }
        else if (CreateGuest.Email == "" || CreateGuest.Email == null || IsValidEmail(CreateGuest.Email) == false)
        {

            GetMessage("Email");

        }
        else if (CreateRes.Amount > 6)
        {
            GetMessage("Chosen");

        }
        else
        {
            CheckDoubleUser();
        }

    }

    //Zet Nieuwe Gast neer in database
    void InsertUser()
    {


        con.SqlQuery("INSERT INTO `guest`(`FullName`, `Email`,`NoShow`,`IsBlocked`) VALUES (@Fullname,@Email,0,0)");
        con.Cmd.Parameters.AddWithValue("@Fullname", CreateGuest.FullName);
        con.Cmd.Parameters.AddWithValue("@Email", CreateGuest.Email);
        con.NonQueryEx();

        CheckDoubleUser();

    }

    //Zet Gast neer in database
    void InsertReservation()
    {
        if(CreateRes.Table == 0)
        {
            GetMessage("Chosen");
        }
        else
        {
            con.SqlQuery("INSERT INTO `reservation`(`Date`, `DayPart`, `TableNumber`, `Guest`, `Amount`, `IsConfirm`) VALUES (@Date,@Daypart,@TableNumber,@Guest,@Amount, 'Ja')");
            con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date);
            con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
            con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
            con.Cmd.Parameters.AddWithValue("@Guest", CreateGuest.id);
            con.Cmd.Parameters.AddWithValue("@Amount", CreateRes.Amount);
            con.NonQueryEx();
        }


        GetMessage("Succes");
        sendMail();
    }

    //Verstuurd mail naar gast met bevestiging link
    public void sendMail()
    {
        con.SqlQuery("SELECT `id_Reservation` FROM `reservation` WHERE `Guest`=@Guest AND `Date`=@Date AND `DayPart`=@Daypart AND `TableNumber`=@TableNumber");
        con.Cmd.Parameters.AddWithValue("@Guest", CreateGuest.id.ToString());
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date.ToString("yyyy-MM-dd"));
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
        con.QueryEx();

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            CreateRes.id = Convert.ToInt32(dr[0].ToString());
        }

        string messageone = "Er is een reservering gemaakt. Klik op de link om de reservering te bevestigen.";
        string Link = "https://localhost:44390/Confirm?GetGuestid=" + CreateGuest.id + "&GetRes=" + CreateRes.id;
        string messagetwo = " Als u niet wilt reserveren of dit niet het geval is negeer dan deze mail.";
        string EndMail = "Alvast bedankt voor uw reserveringen ";
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
                                      <td class=TitleMessage>Bevestigen van reservering</td>
                                      <td class=BacKColor></td>
                                  </tr>
                                        <tr>
                                            <td class=""side-Right-Left""><td class=""message"">" + messageone + "<br><a href=" + Link + ">Bevestig</a><br>" + messagetwo + "</td><td class=side-Right-Left> </td> </td> " +
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



        string subject = "Bevestigen van reservering!";
        MailMessage mailMessage = new MailMessage("reserveringsysteem2@gmail.com", CreateGuest.Email, subject, htmlBody);
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
