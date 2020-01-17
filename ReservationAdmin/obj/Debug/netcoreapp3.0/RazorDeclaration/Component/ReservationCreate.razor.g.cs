#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a53d016d57a87e16a99fbcfb854a80cad16c42"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
      


    SqlConnection con = new SqlConnection();
    public string Message;
    Reservation CreateRes = new Reservation();
    Guest CreateGuest = new Guest();
    public int Rese;

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

        if (CreateRes.Amount != 0)
        {
          CreateRes.Table = 0;
            TablesReset();
            ReserveTable();
            LessThenSixFourOrTwo();
        }



    }
    void ReserveTable()
    {
        CreateRes.date = DateTime.Now;
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

    async Task TablesReset()
    {
        await JsRuntime.InvokeVoidAsync("ResetTables");
    }

    async Task LessThenSixFourOrTwo()
    {
        await JsRuntime.InvokeVoidAsync("Disabled", CreateRes.Amount);
    }
    //Gereserveerd Tafel
    async Task DisabledReserved(int Tableres)
    {
        await JsRuntime.InvokeVoidAsync("DisabledReserved", Tableres);
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

        if (IsValidEmail(CreateGuest.Email) != false)
        {
            con.SqlQuery("INSERT INTO `guest`(`FullName`, `Email`) VALUES (@Fullname,@Email)");
            con.Cmd.Parameters.AddWithValue("@Fullname", CreateGuest.FullName);
            con.Cmd.Parameters.AddWithValue("@Email", CreateGuest.Email);
            con.NonQueryEx();
            CheckDoubleUser();
        }


    }
    //Zet Gast neer in database
    void InsertReservation()
    {


        con.SqlQuery("INSERT INTO `reservation`(`Date`, `DayPart`, `TableNumber`, `Guest`, `Amount`) VALUES (@Date,@Daypart,@TableNumber,@Guest,@Amount)");
        con.Cmd.Parameters.AddWithValue("@Date", CreateRes.date);
        con.Cmd.Parameters.AddWithValue("@Daypart", CreateRes.Daypart);
        con.Cmd.Parameters.AddWithValue("@TableNumber", CreateRes.Table);
        con.Cmd.Parameters.AddWithValue("@Guest", CreateGuest.id);
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
