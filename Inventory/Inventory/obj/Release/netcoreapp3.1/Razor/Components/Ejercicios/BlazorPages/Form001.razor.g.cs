#pragma checksum "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05326755d552639b717f4ccbedc6aa015659ecc0"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Ejercicios.BlazorPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
    public partial class Form001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                 message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 2 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                 message2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message2 = __value, message2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "value", "Haga clic");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                                 ChangeText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddContent(16, 
#nullable restore
#line 4 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
      message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\volve\Proyectos\AprendiendoRazor\Inventory\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
       
    [Parameter]
    public string Message { get; set; }


    string message = "un contenido";
    string message2;

    protected override async Task OnInitializedAsync()
    {
        message = Message;
    }

    private void ChangeText()
    {
        message = message2;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
