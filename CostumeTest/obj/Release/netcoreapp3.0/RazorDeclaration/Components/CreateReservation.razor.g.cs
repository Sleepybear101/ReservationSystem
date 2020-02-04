#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5404d62efc6961b775c6ac3f12b1b6699237f7d0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ReservationGuest.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using ReservationGuest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class CreateReservation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 284 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
      

    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();
    Guest CreateGuest = new Guest();
    public int TableNummerReserved;

    [Parameter]
    public string DateInText { get; set; }
    public string DayPart { get; set; }



    // Kijkt of de terug of volgende knop is gedrukt
    async Task NextOrLastDiv(bool NextOrLastDiv, int FormqClicked)
    {
        // als de NextOrLastDiv false wordt de javascript function LastDiv gebruikt anders  function NextDiv gebruikt
        if (NextOrLastDiv == false)
        {
            await JsRuntime.InvokeVoidAsync("LastDiv", FormqClicked);

            //Info legen terug
            if (FormqClicked == 2 || FormqClicked == 4)
            {
                CreateRes.Daypart = "";
            }
            else if (FormqClicked == 3 || FormqClicked == 5)
            {
                CreateRes.Table = 0;
                CreateRes.Daypart = "";

            }
        }
        else
        {
            // checkt of de email correct om de function NextDiv gebruiken
            if (IsValidEmail(CreateGuest.Email) != false)
            {
                await JsRuntime.InvokeVoidAsync("NextDiv", FormqClicked);
            }
        }
    }

    //Gereserveerd Tafel
    async Task DisabledReserved(int Tableres)
    {
        await JsRuntime.InvokeVoidAsync("DisabledReserved", Tableres);
    }

    //Wanneer aantal personen
    async Task LessThenSixFourOrTwo()
    {
        await JsRuntime.InvokeVoidAsync("Disabled", CreateRes.Amount);
    }

    //alles van de tafels of stappen worden teruggezet
    async Task ResetTableOrSteps(string subject)
    {
        if (subject == "ResetTables")
        {
            await JsRuntime.InvokeVoidAsync("ResetTables");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("ResetSteps");
        }
    }

    async Task WholDayPart()
    {
        await JsRuntime.InvokeVoidAsync("HoldValue", CreateRes.Daypart);
    }


    // Kijkt of de terug of volgende knop is gedrukt
    async Task GetMessage(string subject)
    {
        if (subject == "Succes")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }
        else if (subject == "Blocked")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }
        else if (subject == "Chosen")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }
        else if (subject == "Email")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }
        else if(subject == "Time")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);
        }
    }

    //Kijkt naar welke datum is gekozen
    async Task CheckWhichDate()
    {
        await JsRuntime.InvokeVoidAsync("WhichDate", CreateRes.date.ToString("yyyy-MM-dd"));
    }

    //Pakt de dagdeel die voorbij is gegaan
    async Task CheckDateTime(string Daypart)
    {
        await JsRuntime.InvokeVoidAsync("WhichDaypart", Daypart);
    }

    //Kijkt of de tijd van de datum al na een dagdeel is om een dagdeel te blokkeren 
    void  CheckDateTime()
    {
        DateTime Choosingdate = CreateRes.date.Date;
        DateTime CurrentTime  = DateTime.Now;
        TimeSpan timeLunch = new TimeSpan(11, 0, 0);
        TimeSpan timeDinner = new TimeSpan(17, 0, 0);
        DateTime DeadlineLunch = Choosingdate.Add(timeLunch);
        DateTime DeadlineDinner = Choosingdate.Add(timeDinner);

        double TotalBetweenLunch = (DeadlineLunch - CurrentTime).TotalHours;
        double TotalBetweenDinner = (DeadlineDinner - CurrentTime).TotalHours;

        if ( TotalBetweenLunch < 3 )
        {
            CheckDateTime("Lunch");
        }
        if (TotalBetweenDinner < 3)
        {
            CheckDateTime("Dinner");
        }
        GuestLastday();
        NextOrLastDiv(true, 2);
    }

    //Pakt de dagdeel van zelfde dag 
    void GuestLastday()
    {
        con.SqlQuery("SELECT reservation.DayPart FROM reservation INNER JOIN guest ON reservation.Guest = guest.id_Guest WHERE reservation.Date =@Date AND guest.FullName =@Name AND guest.Email=@Mail ");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date.ToString("yyyy-MM-dd"));
        con.Cmd.Parameters.AddWithValue("@Name", CreateGuest.FullName);
        con.Cmd.Parameters.AddWithValue("@Mail", CreateGuest.Email);

        foreach (DataRow dr in con.QueryEx().Rows)
        {
            CheckDateTime(dr[0].ToString());
        }
    }

    //Dagdeel gekozen
    void CheckDaypart()
    {
        if (CreateRes.Daypart == "" || CreateRes.Daypart == null)
        {
            GetMessage("Chosen");
        }
        else
        {
            ResetTableOrSteps("ResetTables");
            CheckWhichDate();
            ReserveTable();
            LessThenSixFourOrTwo();
            NextOrLastDiv(true, 3);
        }
    }

    //Tafel gekozen
    void CheckTable()
    {
        if (CreateRes.Table == 0 )
        {
            GetMessage("Chosen");
        }
        else
        {
            NextOrLastDiv(true, 4);
        }
    }


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

    //Kijkt of veld wel gevuld of gekozen zijn en verder kan naar volgende form
    void CheckBlockedOrNotFilled()
    {
        if (CreateGuest.FullName == null || CreateRes.Amount == 0  || CreateGuest.FullName == "")
        {
            GetMessage("Chosen");
        }
        else if (IsValidEmail(CreateGuest.Email) == false)
        {
            GetMessage("Email");
        }
        else if (CreateRes.Amount > 6 || CreateRes.Amount < 1)
        {
            GetMessage("Chosen");
        }
        else
        {
            con.SqlQuery("SELECT Count(`IsBlocked`) FROM `guest` WHERE `Email`=@Email AND `IsBlocked`=1");
            con.Cmd.Parameters.AddWithValue("@Email", CreateGuest.Email);
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                CreateGuest.IsBlocked = Convert.ToInt32(dr[0].ToString());
            }
            if (CreateGuest.IsBlocked >= 1)
            {
                GetMessage("Blocked");
            }
            else
            {
                NextOrLastDiv(true, 1);
            }

        }
    }

    //Pak de waarde van geselecteerd Tafel
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
            DayPart = "Lunch 11:00 - 16:00";
        }
        else
        {
            CreateRes.Daypart = "Dinner";
            DayPart = "Dinner 17:00 - 20:00";

        }

        CultureInfo ci = new CultureInfo("nl-NL");
        var month = CreateRes.date.ToString("dddd, dd MMMM yyyy", ci);
        DateInText = month;

        WholDayPart();
    }

    //Zet de tafels naar gereserveerd
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
        if (CreateGuest.Email == "" || CreateGuest.FullName == ""|| CreateRes.Daypart == "" || CreateRes.date == null || CreateRes.Amount == null)
        {
            GetMessage("Chosen");
        }
        else
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
    }
    //Zet Gast neer in database
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
        con.SqlQuery("INSERT INTO `reservation`(`Date`, `DayPart`, `TableNumber`, `Guest`, `Amount`,`IsConfirm`) VALUES (@Date,@Daypart,@TableNumber,@Guest,@Amount,'Nee')");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date);
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
        con.Cmd.Parameters.AddWithValue("@Guest", CreateGuest.id);
        con.Cmd.Parameters.AddWithValue("@Amount", CreateRes.Amount);
        con.NonQueryEx();

        GetMessage("Succes");
        sendMail();
        ResetTableOrSteps("Steps");
        NextOrLastDiv(true, 0);

        CreateGuest.Email = null;
        CreateGuest.FullName = null;
        CreateRes.Amount = 0;
        CreateRes.Daypart = "";
        CreateRes.date = DateTime.Today;
        CreateRes.Table = 0; 
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
        string Link = "https://reserveringsysteem.azurewebsites.net/Confirm?GetGuestid=" + CreateGuest.id + "&GetRes=" + CreateRes.id;
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
                                                <td class=""side-Right-Left""><td class=""message"">" + messageone + "<br>"+DateInText+"<br><a href=" + Link + ">Bevestig</a><br>" + messagetwo + "</td><td class=side-Right-Left> </td> </td> " +
                                          "</tr> " +
                                       "</tbody> " +
                                 " <tfoot> " +
                                    "<tr>" +
                                      " <td class=BacKColor></td>" +
                                      " <td class=EndMessage>"+EndMail+"</td>" +
                                      " <td class=BacKColor></td>" +
                                   " </tr> " +
                                 "</tfoot>" +
                                "</body> " +
                              "</html>";

        string subject = "Bevestigen van reservering!";
        MailMessage mailMessage = new MailMessage("reserveringsysteem2@gmail.com", CreateGuest.Email ,subject,htmlBody);
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
