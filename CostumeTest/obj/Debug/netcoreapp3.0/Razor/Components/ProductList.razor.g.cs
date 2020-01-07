#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a912ad9b148eeb554cd515dfa6258ef765e6c870"
namespace ReservationGuest.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
using CostumeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
using CostumeTest.Services;

#line default
#line hidden
#nullable disable
    public class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "background-color: #ffffff;   width: 65%; height: 37%;  margin-left: 18%; margin-top: 62px; padding: 1% 4% 7% 1%;");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<h1>Tafel kiezen</h1>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-group");
            __builder.AddAttribute(6, "style", " background-image: url(\'images/tafel-van-zes.png\');  width:500px; height:450px; margin-left: 69px;\r\n    margin-bottom: 36px; ");
            __builder.AddMarkupContent(7, "\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", " margin-left:21%; margin-top: 7%;");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 14 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
                 for (i = 1; i <= 3; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "style", " border:none ;background-color:dimgray ;width: 47px;\r\n    height: 57px; margin-left: 10px;   margin-right: 33px; ");
            __builder.AddAttribute(14, "data-toggle", "modal");
            __builder.AddAttribute(15, "data-target", "#productModal");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
                         TableNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 20 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
                    TableNumber++;
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.AddMarkupContent(23, @"<div style=""margin-top: 7%;"">
                <button style="" border:none ;background-color:dimgray ; width: 47px; height: 87px; margin-left: 27px;
    margin-right: 40px; margin-top: 15px;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    4
                </button>
            </div>

            ");
            __builder.AddMarkupContent(24, @"<div style=""padding-left: 50%;height: 7%; margin-top: -3%;"">
                <button style="" border:none ;background-color:dimgray ;width: 30px; height: 35px; margin-right:48px;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">6</button>
                <button style="" border:none ;background-color:dimgray ;width: 30px; height: 35px; "" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">5</button>
            </div>

            ");
            __builder.AddMarkupContent(25, @"<div style=""width: 27%; margin-left: 1%;margin-bottom: 24%;  margin-top: 3%;"">
                <button style="" border:none ;background-color:dimgray ;width: 58px;  height: 48px; margin-left: 25px;  margin-right: 33px;  margin-top: 17%;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    8
                </button>
                <button style="" border:none ;background-color:dimgray ; width: 58px;  height: 48px;  margin-left: 25px;  margin-right: 33px;  margin-top: 31%;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    10
                </button>
                <button style="" border:none ;background-color:dimgray;  width: 90px; height: 48px; margin-left: 25px; margin-right: 33px;   margin-top: 34%;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    11
                </button>
            </div>

            ");
            __builder.AddMarkupContent(26, @"<div style=""  width: 19%; margin-left: 1%;   "">
                <button style="" border:none ;background-color:dimgray ; width: 58px;height: 46px;margin-left: 7px;margin-right: 6px; margin-top: 20%;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    7
                </button>
                <button style="" border:none ;background-color:dimgray ; width: 59px;
    height: 45px;
    margin-left: 7px;
    margin-right: 33px;
    margin-top: 55%;"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                    9
                </button>

            </div>

        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<button type=\"submit\" class=\"btn btn-primary\" style=\"float:left\">\r\n            <a href=\"/Daypart\">Terug</a>\r\n        </button>\r\n\r\n        ");
            __builder.AddMarkupContent(29, "<button type=\"submit\" class=\"btn btn-primary\" style=\"float:right\">\r\n            <a href=\"/Overzicht\">Volgende</a>\r\n        </button>\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 72 "C:\Users\wurud\Documents\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
=======
#line 73 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\CostumeTest\Components\ProductList.razor"
>>>>>>> b574726aef566ebee855d162e97d1f9d3e7660fd
 

        Product selectedProduct;
        string selectedProductId;
        int currentRating = 0;
        public int TableNumber = 1;
        public int i;

        void SubmitRating(int rating, string productId)
        {
            selectedProductId = productId;
            selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
            System.Console.WriteLine($"Rating received for{selectedProduct.Id}: {rating}");

            ProductService.AddRating(selectedProductId, rating);

        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
