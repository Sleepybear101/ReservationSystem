#pragma checksum "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Components\Daypart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40d50ff537a71962acc9f87d4a950b6a0b221b6"
// <auto-generated/>
#pragma warning disable 1591
namespace CostumeTest.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Components\Daypart.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Components\Daypart.razor"
using CostumeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Components\Daypart.razor"
using CostumeTest.Services;

#line default
#line hidden
#nullable disable
    public class Daypart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div style=""background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;"">
        <h1> Kies dagdeel</h1>

        <ul class=""nav nav-pills"" style=""border: 1px solid #E6DBDA; width: 239px;border-radius: 5px;"">
            <li style=""border-right:1px solid #E6DBDA;"">
                <a data-toggle=""pill"">
                    <h4>Lunch</h4>
                    <p>11:00 - 16:00</p>
                </a>
            </li>
            <li>
                <a data-toggle=""pill"">
                    <h4>Diner</h4>
                    <p>17:00 - 20:00</p>
                </a>
            </li>

        </ul>
        
        <button type=""submit"" class=""btn btn-primary"" style=""float:left"">
            <a href=""/Datum"">Terug</a>
        </button>

        <button type=""submit"" class=""btn btn-primary"" style=""float:right"">
            <a href=""/Tafels"">Volgende</a>
        </button>
    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
