#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246567b7514e91c90c57525aa2cad4b72b6b07de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CostumeTest.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 1 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\_ViewImports.cshtml"
using CostumeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml"
using ReservationGuest.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246567b7514e91c90c57525aa2cad4b72b6b07de", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3cc114efff54a625cdd69d6003ee12578c96bd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--<div class=""progress"" style=""width: 65%; margin-left: 18%;"">
  <div class=""progress-bar"" role=""progressbar"" style=""width: 35%; padding-left: 50px;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
</div>
-->

<html xmlns=""http://www.w3.org/1999/xhtml"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246567b7514e91c90c57525aa2cad4b72b6b07de4460", async() => {
                WriteLiteral(@"
    <title>Reservatie Form</title>


    <script src=""http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.5.js"" type=""text/javascript""></script>


    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""div[class=divs]"").hide();
            $(""div[id=div1"").show();
            function checkifEmpty() {
                if ($(""[class=form-controls1]"").is(':empty')) {
                    $filled = false;
                    console.WriteLine(""niet helemaal ingevuld"");
                } else {
                    $filled = true;
                    console.WriteLine(""wel iets in"");
                }
            }
            $(""input[type=button][class=buttons]"").click(function () {
                checkifEmpty();
                if (filled) {
                    $(""div[class=divs]"").hide();
                    $(""div[id=div"" + $(this).attr(""id"") + ""]"").show();
                }
            });
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246567b7514e91c90c57525aa2cad4b72b6b07de6524", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 51 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Pages\Index.cshtml"
Write(await Html.RenderComponentAsync<Component>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script src=""_framework/blazor.server.js""></script>
    <script src=""js/button.js""></script>

    <!--=        <br />
            <br />
            <input id=""3"" type=""button"" value=""3"" class=""buttons"" />
            <div id=""div3"" class=""divs"" style=""width: 200px; height: 100px; background-color: pink"">
                Div 3
            </div>
            <br />
            <br />
            <input id=""4"" type=""button"" value=""4"" class=""buttons"" />
            <div id=""div4"" class=""divs"" style=""width: 200px; height: 100px; background-color: pink"">
                Div 4
            </div>
            <br />
            <br />
            <input id=""5"" type=""button"" value=""5"" class=""buttons"" />
            <div id=""div5"" class=""divs"" style=""width: 200px; height: 100px; background-color: pink"">
                Div 5
            </div>
            <br />
            <br />
            <input id=""6"" type=""button"" value=""6"" class=""buttons"" />
            <div id=""div6"" class=""divs"" s");
                WriteLiteral("tyle=\"width: 200px; height: 100px; background-color: pink\">\r\n                Div 6\r\n            </div>\r\n            <br />\r\n            <br />-->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
