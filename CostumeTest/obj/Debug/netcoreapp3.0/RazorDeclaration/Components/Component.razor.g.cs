#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d93697c07b5066e58ccc89c3025fdd438319fa"
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
