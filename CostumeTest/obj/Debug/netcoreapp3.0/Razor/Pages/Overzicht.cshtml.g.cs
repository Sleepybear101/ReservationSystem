#pragma checksum "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Pages\Overzicht.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a9b9612598e7844ef814d91ac225ee95ea4e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CostumeTest.Pages.Pages_Overzicht), @"mvc.1.0.razor-page", @"/Pages/Overzicht.cshtml")]
namespace CostumeTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Pages\_ViewImports.cshtml"
using CostumeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Pages\Overzicht.cshtml"
using CostumeTest.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a9b9612598e7844ef814d91ac225ee95ea4e86", @"/Pages/Overzicht.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff23ec070b841c2c0c9d64028c9d1327557c3f1b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Overzicht : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Pages\Overzicht.cshtml"
  
    ViewData["Title"] = "Overzicht";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\wurud\source\repos\CostumeTest\CostumeTest\Pages\Overzicht.cshtml"
Write(await Html.RenderComponentAsync<Overview>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Overrview> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Overrview> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Overrview>)PageContext?.ViewData;
        public Overrview Model => ViewData.Model;
    }
}
#pragma warning restore 1591
