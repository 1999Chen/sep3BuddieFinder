#pragma checksum "D:\c#\sep3UnnamedYet\tier1\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5496ed76282db496af63d12f044fe1f77647c2a"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
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
#nullable restore
#line 2 "D:\c#\sep3UnnamedYet\tier1\Pages\SignUp.razor"
using tier1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "same");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3>BuddieFinder</h3>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "SignInfo");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "SignDone");
            __builder.AddMarkupContent(9, "\r\n            You have succesfully signed up. Welcome to BuddieFinder! \r\n            <br> Go back and log in!\r\n            ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\c#\sep3UnnamedYet\tier1\Pages\SignUp.razor"
                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "go back");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "    \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    \r\n    ");
            __builder.AddMarkupContent(16, "<div id=\"pic3a\">\r\n        <img src=\"pic3a.png\" alt=\"pic3\">\r\n    </div>\r\n    \r\n    ");
            __builder.AddMarkupContent(17, "<div id=\"pic4a\">\r\n        <img src=\"pic4a.png\" alt=\"pic4\">\r\n    </div>\r\n        \r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\c#\sep3UnnamedYet\tier1\Pages\SignUp.razor"
       

    public IUserService clicent=new UserService();
    public async Task back()
    {
        clicent.logout();
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
