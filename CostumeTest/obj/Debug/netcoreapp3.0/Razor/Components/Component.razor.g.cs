#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a194f6498e9b122a0b004b1bd2fbc8f2b180c43"
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
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using ReservationGuest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\Component.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div style=""background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;"">
        <h1>Datum</h1>

        <div id=""datepicker"" data-date=""today""></div>
        <div id=""datepicker"" data-date=""today"" style=""margin-left: 31%; ""></div>

        <div class=""input-group input-daterange"">
            <div class=""input-group-addon""></div>
            <input type=""text"" class=""input-group-addon form-control"">

        </div>

        <button type=""submit"" class=""btn btn-primary"" style=""float:left""></button>
    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
