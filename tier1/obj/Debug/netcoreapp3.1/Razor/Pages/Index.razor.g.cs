#pragma checksum "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c2f0f67b9598c2b1e36db7bba4658e4d5a7ea2a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        ");
                __builder2.AddMarkupContent(3, "<div id=\"header\">\n            <h1>BuddieFinder</h1>\n            <p id=\"unHead\">your personal helper for findidng the true freinds</p>\n        </div>\n\n        ");
                __builder2.AddMarkupContent(4, "<div id=\"gif1\">\n            <img src=\"pic1.gif\" alt=\"gif1\">\n        </div>\n\n\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "id", "logIn");
                __builder2.AddMarkupContent(7, "\n            ");
                __builder2.AddMarkupContent(8, "<div>Username </div> ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "placeholder", "username");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
                                                                                         username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.AddMarkupContent(15, "<div id=\"password\"> Password </div> ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "password");
                __builder2.AddAttribute(18, "placeholder", "password");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
                                                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "id", "LogButt");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
                                        PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(25, " Log in ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "style", "color:red");
                __builder2.AddContent(29, 
#nullable restore
#line 28 "D:\c#\sep3UnnamedYet\tier1\Pages\Index.razor"
                                    message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "id", "signUp");
                __builder2.AddMarkupContent(33, "\n                ");
                __builder2.AddMarkupContent(34, "<div>Aren\'t signed up yet?</div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
                __builder2.AddAttribute(36, "class", "nav-link");
                __builder2.AddAttribute(37, "id", "signUpLink");
                __builder2.AddAttribute(38, "href", "Register");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, "Don\'t miss a chance and do it now!");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n\n        ");
                __builder2.AddMarkupContent(44, "<div id=\"gif2\">\n            <img src=\"pic2.gif\" alt=\"gif2\">\n        </div>\n\n    ");
            }
            ));
            __builder.AddAttribute(45, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
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
