#pragma checksum "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec6c6025af37ebce06b9f4d9b9ab393b2a58ed0"
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
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
using ReservationAdmin.Models;

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
#line 117 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\ReservationCreate.razor"
      


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
    try {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == email;
    }
    catch {
        return false;
    }
}

    void InsertUser()
    {
 
        CreateRes.date = DateTime.Today;

        IsValidEmail(CreateRes.Email);
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
    }
}
#pragma warning restore 1591
