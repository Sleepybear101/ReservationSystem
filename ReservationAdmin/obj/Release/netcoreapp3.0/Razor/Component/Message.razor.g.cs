#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\Message.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623e20fff1a36a9ff915fe295090e32b918b0715"
// <auto-generated/>
#pragma warning disable 1591
namespace ReservationAdmin.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class Message : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""modal fade"" id=""BlockedMessage"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Mail geblokkeerd</h5>
            </div>
            <div class=""modal-body"">
                <p>
                    Het blijkt dat de email waarmee je wilt reserveren is geblokkeerd. Bel het restaurant om een reservering te maken.
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Sluiten</button>
            </div>
        </div>
    </div>
</div>


");
            __builder.AddMarkupContent(1, @"<div class=""modal fade"" id=""NotFilledOrChosenMessage"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Niet ingevuld of gekozen</h5>
            </div>
            <div class=""modal-body"">
                <p>
                    Sommige velden zijn niet correct ingevoerd of gekozen
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Oke</button>
            </div>
        </div>
    </div>
</div>

");
            __builder.AddMarkupContent(2, @"<div class=""modal fade"" id=""EmailNotMessage"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Email niet correct</h5>
            </div>
            <div class=""modal-body"">
                <p>
                    Email niet correct ingevoerd
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Oke</button>
            </div>
        </div>
    </div>
</div>

");
            __builder.AddMarkupContent(3, @"<div class=""modal fade"" id=""ReservationSucces"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Reservering aangemaakt</h5>
            </div>
            <div class=""modal-body"">
                <p>
                    Reservering is aangemaakt.Een mail wordt verzonden om je reservering te bevestigen
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Oke</button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
