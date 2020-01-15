#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05490582a5764ba421c939f815f6e7b598395ce"
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
#line 194 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\CreateReservation.razor"
      
    public int i;
    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();
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
            if (IsValidEmail(CreateRes.Email) != false)
            {
                await JsRuntime.InvokeVoidAsync("NextDiv", FormqClicked);

            }
        }
        //Info legen terug
        if (FormqClicked == 4 || FormqClicked == 2)
        {
            CreateRes.Daypart = "";
        }
        else if (FormqClicked == 3 || FormqClicked == 5)
        {
            CreateRes.Table = 0;
        }
        DateInText = CreateRes.date.ToLongDateString();
    }
    //Gereserfveerd tafel
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
    async Task GetSuccesfulMessage()
    {

        await JsRuntime.InvokeVoidAsync("Message");

    }

    //Blocked email
    async Task BLocked()
    {
        await JsRuntime.InvokeVoidAsync("Blocked");
    }

    //Niet gevuld
    async Task NotFilledOrCorrect(bool Result)
    {
        if (Result == false)
        {
            await JsRuntime.InvokeVoidAsync("NotFilled");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("NotCorrect");
        }
    }

    //Dagdeel gekozen
    void CheckNumberDaypart()
    {
        if (CreateRes.Daypart == "" || CreateRes.Daypart == null)
        {
            NotFilledOrCorrect(false);

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
            NotFilledOrCorrect(false);
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
        if (CreateRes.FullName == null || CreateRes.Amount == 0)
        {
            NotFilledOrCorrect(false);
        }
        else if (IsValidEmail(CreateRes.Email) == false)
        {

            NotFilledOrCorrect(true);

        }
        else
        {
            //SELECT `IsBlocked` FROM `guest` WHERE `Email`=@Email
            con.SqlQuery("SELECT Count(`IsBlocked`) FROM `guest` WHERE `Email`=@Email AND `IsBlocked`=1");
            con.Cmd.Parameters.AddWithValue("@Email", CreateRes.Email);
            foreach (DataRow dr in con.QueryEx().Rows)
            {

                Debug.WriteLine("get");
                CreateRes.IsBlocked = Convert.ToInt32(dr[0].ToString());

            }

            if (CreateRes.IsBlocked >= 1)
            {
                BLocked();
            }
            else
            {
                NextOrLastDiv(true, 1);
            }

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
            DayPart = "Lunch 11:00 - 16:00";
        }
        else
        {
            CreateRes.Daypart = "Dinner";
            DayPart = "Diner 17:00 - 20:00";

        }
        Message = "daypart  gekozen" + CreateRes.Daypart.ToString();
        Debug.WriteLine(Message);


        LessThenSixFourOrTwo();
        ReserveTable();


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

        //SELECT `id_Guest` FROM `guest` WHERE `FullName`='Toos' AND `Email`='Wu.rud@hotmail.com'

        con.SqlQuery("INSERT INTO `guest`(`FullName`, `Email`) VALUES (@Fullname,@Email)");
        con.Cmd.Parameters.AddWithValue("@Fullname", CreateRes.FullName);
        con.Cmd.Parameters.AddWithValue("@Email", CreateRes.Email);
        con.NonQueryEx();

        CheckDoubleUser();

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


        GetSuccesfulMessage();
        NextOrLastDiv(false, 1);


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
