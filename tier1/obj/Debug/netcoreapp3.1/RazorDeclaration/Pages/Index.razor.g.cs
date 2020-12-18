#pragma checksum "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c2f0f67b9598c2b1e36db7bba4658e4d5a7ea2a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginComponent
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
#line 2 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
using tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
using tier1.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
using tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
       
    private User CurrentPerson;

    private string message;
    public string username { set; get; }

    public string password { set; get; }
    


    IUserService client = new UserService();

    public async Task PerformLogin()
    {
        message = "";
        try
        {
            client.Connect();
            Thread.Sleep(100);
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            client.setcurrentName(username);
            NavigationManager.NavigateTo("/ProfileView");
            message = "Login succeed!";
        }
        catch (Exception e)
        {
            message = "Username or password is incorrect!";
            Console.WriteLine(e);
        }
        
    }

 
    

    public async Task PerformLogout()
    {
        message = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/Login");
            message = "Logout succeed!";
        }
        catch (Exception e)
        {
            message = e.Message;
        }
    }

    public async Task PerformRegister(string username, string password)
    {
        client.RegisterUser(username, password);
    }









#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
