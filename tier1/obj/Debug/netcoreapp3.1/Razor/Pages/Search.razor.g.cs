#pragma checksum "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d5d7d92e9298a1b5a5e6c922c8b0476d7b1d1d"
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
#line 2 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
using tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
using tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
using tier1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "same");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "menu");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<h3 id=\"h3prof\">BuddieFinder</h3>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "href", "friendslist");
            __builder.AddAttribute(9, "class", "up");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, " Friends list");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "chat");
            __builder.AddAttribute(15, "class", "up");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Chat");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "profileview");
            __builder.AddAttribute(21, "class", "up");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Profile");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "href", "search");
            __builder.AddAttribute(27, "class", "up");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(29, "Search");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "href", "FriendRequest");
            __builder.AddAttribute(33, "class", "up");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(35, "FriendRequest");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\n     \n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "id", "searchbox");
            __builder.AddMarkupContent(39, "\n            ");
            __builder.AddMarkupContent(40, "<div> Username </div> ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                                                  username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n            ");
            __builder.AddMarkupContent(46, "<div> Firstname </div> ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                                                   firstname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstname = __value, firstname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.AddMarkupContent(52, "<div> LastName </div> ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                                                  lastname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastname = __value, lastname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddMarkupContent(59, "\n                ");
            __builder.AddMarkupContent(60, "<label>Sex: </label>\n                ");
            __builder.OpenElement(61, "select");
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                    setSex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "\n                    ");
            __builder.OpenElement(64, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n                    ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "M");
            __builder.AddContent(68, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n                    ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "F");
            __builder.AddContent(72, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddMarkupContent(77, "\n                ");
            __builder.AddMarkupContent(78, "<label>Major: </label>\n                ");
            __builder.OpenElement(79, "select");
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                    setMajor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(81, "\n                    ");
            __builder.OpenElement(82, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n                    ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "Architectural Technology and Construction Management");
            __builder.AddContent(86, "Architectural Technology and Construction Management");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n                    ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "Character Animation");
            __builder.AddContent(90, "Character Animation");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                    ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "Civil Engineering ");
            __builder.AddContent(94, "Civil Engineering ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n                    ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "Climate and Supply Engineering ");
            __builder.AddContent(98, "Climate and Supply Engineering ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n                    ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "Computer Graphic Arts");
            __builder.AddContent(102, "Computer Graphic Arts");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                    ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "Construction Technology");
            __builder.AddContent(106, "Construction Technology");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n                    ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "Design and Business");
            __builder.AddContent(110, "Design and Business");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n                    ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "Design, Technology and Business");
            __builder.AddContent(114, "Design, Technology and Business");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n                    ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", "Global Business Engineering");
            __builder.AddContent(118, "Global Business Engineering");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\n                    ");
            __builder.OpenElement(120, "option");
            __builder.AddAttribute(121, "value", "Global Nutrition and Health ");
            __builder.AddContent(122, "Global Nutrition and Health ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n                    ");
            __builder.OpenElement(124, "option");
            __builder.AddAttribute(125, "value", "Graphic Storytelling");
            __builder.AddContent(126, "Graphic Storytelling");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\n                    ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "International Sales and Marketing Management");
            __builder.AddContent(130, "International Sales and Marketing Management");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\n                    ");
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", "Marketing Management");
            __builder.AddContent(134, "Marketing Management");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n                    ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "Materials Science Engineering");
            __builder.AddContent(138, "Materials Science Engineering");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n                    ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "value", "Mechanical Engineering");
            __builder.AddContent(142, "Mechanical Engineering");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n                    ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "Software Technology Engineering");
            __builder.AddContent(146, "Software Technology Engineering");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\n                    ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "Value Chain Management");
            __builder.AddContent(150, "Value Chain Management");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n            ");
            __builder.AddMarkupContent(154, "<div> Hometown </div> ");
            __builder.OpenElement(155, "input");
            __builder.AddAttribute(156, "type", "text");
            __builder.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                                                  hometown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hometown = __value, hometown));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\n            ");
            __builder.AddMarkupContent(160, "<div> Hobbies </div> ");
            __builder.OpenElement(161, "input");
            __builder.AddAttribute(162, "type", "text");
            __builder.AddAttribute(163, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                                                                 hobbies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(164, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hobbies = __value, hobbies));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\n\n        ");
            __builder.OpenElement(167, "div");
            __builder.AddMarkupContent(168, "\n            ");
            __builder.OpenElement(169, "button");
            __builder.AddAttribute(170, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                              search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(171, " search ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\n            ");
            __builder.OpenElement(173, "button");
            __builder.AddAttribute(174, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                              clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(175, " clear ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\n        ");
            __builder.OpenElement(178, "div");
            __builder.AddMarkupContent(179, "\n            ");
            __builder.OpenElement(180, "label");
            __builder.AddContent(181, " ");
            __builder.AddContent(182, 
#nullable restore
#line 60 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\n\n\n        ");
            __Blazor.Assignment.Pages.Search.TypeInference.CreateTableTemplate_0(__builder, 185, 186, 
#nullable restore
#line 64 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                              result

#line default
#line hidden
#nullable disable
            , 187, (__builder2) => {
                __builder2.AddMarkupContent(188, "\n                ");
                __builder2.AddMarkupContent(189, "<th>Username</th>\n                ");
                __builder2.AddMarkupContent(190, "<th>FirstName</th>\n                ");
                __builder2.AddMarkupContent(191, "<th>LastName</th>\n                ");
                __builder2.AddMarkupContent(192, "<th>Sex</th>\n                ");
                __builder2.AddMarkupContent(193, "<th>Age</th>\n                ");
                __builder2.AddMarkupContent(194, "<th>Birthday</th>\n                ");
                __builder2.AddMarkupContent(195, "<th>Hobbies</th>\n                ");
                __builder2.AddMarkupContent(196, "<th>Major</th>\n                ");
                __builder2.AddMarkupContent(197, "<th>Hometown</th>\n                ");
                __builder2.AddMarkupContent(198, "<th>Description</th>\n            ");
            }
            , 199, (context) => (__builder2) => {
                __builder2.AddMarkupContent(200, "\n                ");
                __builder2.OpenElement(201, "td");
                __builder2.AddContent(202, 
#nullable restore
#line 78 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                      context.username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(203, "\n                ");
                __builder2.OpenElement(204, "td");
                __builder2.AddContent(205, 
#nullable restore
#line 79 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.firstname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\n                ");
                __builder2.OpenElement(207, "td");
                __builder2.AddContent(208, 
#nullable restore
#line 80 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.lastname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\n                ");
                __builder2.OpenElement(210, "td");
                __builder2.AddContent(211, 
#nullable restore
#line 81 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(212, "\n                ");
                __builder2.OpenElement(213, "td");
                __builder2.AddContent(214, 
#nullable restore
#line 82 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(215, "\n                ");
                __builder2.OpenElement(216, "td");
                __builder2.AddContent(217, 
#nullable restore
#line 83 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.birthday

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\n                ");
                __builder2.OpenElement(219, "td");
                __builder2.AddContent(220, 
#nullable restore
#line 84 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.hobbies

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(221, "\n                ");
                __builder2.OpenElement(222, "td");
                __builder2.AddContent(223, 
#nullable restore
#line 85 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.major

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(224, "\n                ");
                __builder2.OpenElement(225, "td");
                __builder2.AddContent(226, 
#nullable restore
#line 86 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.hometown

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(227, "\n                ");
                __builder2.OpenElement(228, "td");
                __builder2.AddContent(229, 
#nullable restore
#line 87 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
                     context.description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(230, "\n            ");
            }
            );
            __builder.AddMarkupContent(231, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\c#\sep3UnnamedYet\tier1\Pages\Search.razor"
       

    public string username { set; get; }

    public string password { set; get; }

    public string firstname { set; get; }

    public string lastname { set; get; }

    public int age { set; get; }

    public string sex { set; get; }

    public string birthday { set; get; }

    public string hobbies { set; get; }

    public string major { set; get; }

    public string hometown { set; get; }

    public string description { set; get; }

    public string message { set; get; }

    public List<User> result = new List<User>();

    protected override void OnInitialized()
    {
        result = userService.getAllUsers();
        sex = "M";
    }

  
    
    

    public async Task search()
    {
        SearchUser user = new SearchUser()
        {
            username = this.username,
            firstname = this.firstname,
            lastname = this.lastname,
            sex = this.sex,
            major = this.major,
            hometown = this.hometown,
            hobbies = this.hobbies,
        };
        result = userService.searchUsers(user);
    }


    public async Task clear()
    {
    }


    public void setMajor(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        major = result;
    }

    public void setSex(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        sex = result;
    }










#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
    }
}
namespace __Blazor.Assignment.Pages.Search
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTableTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::Assignment.Pages.TableTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591