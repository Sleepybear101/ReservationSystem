#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c0a05ad82c807db8f99c82dd9f65a0476b79f9"
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
#line 7 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
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
#line 222 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
      
    public int i;
    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();
    Guest CreateGuest = new Guest();
    public int Rese;
    [Parameter]
    public DateTime date { get; set; } = DateTime.Now;
    public string DateInText { get; set; }
    public string DayPart { get; set; }

    // Kijkt of de terug of volgende knop is gedrukt
    async Task NextOrLastDiv(bool NextOrLastDiv, int FormqClicked)
    {
        CreateRes.date = date;
        // als de NextOrLastDiv false wordt de javascript function LastDiv gebruikt anders  function NextDiv gebruikt
        if (NextOrLastDiv == false)
        {
            await JsRuntime.InvokeVoidAsync("LastDiv", FormqClicked);


        }
        else
        {
            // checkt of de email correct om de function NextDiv gebruiken
            if (IsValidEmail(CreateGuest.Email) != false)
            {
                await JsRuntime.InvokeVoidAsync("NextDiv", FormqClicked);

            }
        }

        //Info legen terug
        if (FormqClicked == 2)
        {
            CreateRes.Daypart = "";
        }
        else if (FormqClicked == 3 || FormqClicked == 5)
        {
            CreateRes.Table = 0;
        }

        DateInText = CreateRes.date.ToLongDateString();

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

    // Kijkt of de terug of volgende knop is gedrukt
    async Task GetMessage(string subject)
    {
        if (subject == "Succes")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }else if (subject == "Blocked")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }else if (subject == "Chosen")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

        }else if (subject == "Email")
        {
            await JsRuntime.InvokeVoidAsync("Message", subject);

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

            NextOrLastDiv(true, 3);
        }
    }

    //Tafel gekozen
    void CheckTable()
    {
        if (CreateRes.Table == 0 || CreateRes.Table == null)
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

    void CheckBlockedOrNotFilled()
    {
        if (CreateGuest.FullName == null || CreateRes.Amount == 0)
        {
            GetMessage("Chosen");
        }
        else if (IsValidEmail(CreateGuest.Email) == false)
        {

            GetMessage("Email");

        }
        else if (CreateRes.Amount > 6)
        {
            GetMessage("Chosen");

        }else{
            //SELECT `IsBlocked` FROM `guest` WHERE `Email`=@Email
            con.SqlQuery("SELECT Count(`IsBlocked`) FROM `guest` WHERE `Email`=@Email AND `IsBlocked`=1");
            con.Cmd.Parameters.AddWithValue("@Email", CreateGuest.Email);
            foreach (DataRow dr in con.QueryEx().Rows)
            {

                Debug.WriteLine("get");
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

        ReserveTable();
        LessThenSixFourOrTwo();


    }

    void ReserveTable()
    {

        //  SELECT `TableNumber` FROM `reservation` WHERE `Date`=@Date  AND `DayPart`=@Daypart
        con.SqlQuery("SELECT `TableNumber` FROM `reservation` WHERE `Date`=@Date  AND `DayPart`=@Daypart");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date.ToString("yyyy-MM-dd"));
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        foreach (DataRow dr in con.QueryEx().Rows)
        {
            Rese = Convert.ToInt32(dr[0].ToString());
            DisabledReserved(Rese);
        }
    }


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
    //Zet Gast neer in database
    void InsertUser()
    {

        //SELECT `id_Guest` FROM `guest` WHERE `FullName`='Toos' AND `Email`='Wu.rud@hotmail.com'

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
        NextOrLastDiv(true, 0);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
