#pragma checksum "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607e04ad83edec3e6ae24cbda4fa87e3d267a926"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InputsOutputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Inventory</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "product/list");
            __builder.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de Productos\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "category/list");
            __builder.AddAttribute(45, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de Categorías\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "nav-item px-3");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "inputOutput/list");
            __builder.AddAttribute(56, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de Movimientos\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "nav-item px-3");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "class", "nav-link");
            __builder.AddAttribute(66, "href", "storage/list");
            __builder.AddAttribute(67, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 31 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de Almacenamiento\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "nav-item px-3");
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", "nav-link");
            __builder.AddAttribute(77, "href", "warehouse/list");
            __builder.AddAttribute(78, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 36 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(80, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de Bodega\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "li");
            __builder.AddAttribute(84, "class", "nav-item px-3");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
            __builder.AddAttribute(87, "class", "nav-link");
            __builder.AddAttribute(88, "href", "counter");
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(90, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item px-3");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(96);
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "fetchdata");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\Proyectos\AprendiendoRazor\Inventory\Inventory\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
