#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Datum.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc111bc311ca4693aa47e8bb8acfdac6fe7ebd2"
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
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Datum.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Datum.razor"
using CostumeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\Datum.razor"
using CostumeTest.Services;

#line default
#line hidden
#nullable disable
    public class Datum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div style=""background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;"">
        <h1>Datum</h1>
  
        
        <button type=""submit"" class=""btn btn-primary"" style=""float:left"">
            <a href=""/Index"">Terug</a>
        </button>

        <button type=""submit"" class=""btn btn-primary"" style=""float:right"">
            <a href=""/Dagdeel"">Volgende</a>
        </button>
    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
