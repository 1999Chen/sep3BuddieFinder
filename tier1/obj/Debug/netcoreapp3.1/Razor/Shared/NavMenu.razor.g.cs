#pragma checksum "D:\c#\sep3UnnamedYet\tier1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9b874df6019d9dd114b38907043d487cb53e9e"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\c#\sep3UnnamedYet\tier1\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "nav flex-column");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", "nav-item px-3");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "nav-link");
            __builder.AddAttribute(10, "href", "");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "D:\c#\sep3UnnamedYet\tier1\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
