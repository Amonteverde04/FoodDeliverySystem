#pragma checksum "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantHomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044119e630cf20f1b68ddd57c33957950ef9f485"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyMeal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using EasyMeal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using EasyMeal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Restaurant-Home-page")]
    public partial class RestaurantHomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/RestaurantHomePage.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "RestuarantList");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "Header");
            __builder.AddMarkupContent(7, @"<div class=""Search""><form class=""SearchForm"" action=""/""><button class=""Glass"" type=""button""><img class=""SearchGlassSvg"" src=""/Assets/RestaurantList/SearchGlass.svg""></button>
                    <input class=""SearchBar"" type=""text"" placeholder=""Search"" name=""search""></form></div>
            ");
            __builder.AddMarkupContent(8, "<div class=\"LogoContainer\"><a href><img class=\"logo\" src=\"/Assets/RestaurantList/RestaurantLogo.svg\" alt=\"EasyMeal\"></a></div>\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"Cart\"><a href><img class=\"Cart\" src=\"/Assets/RestaurantHomePage/cart.png\" alt=\"Cart\"></a></div>");
#nullable restore
#line 23 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantHomePage.razor"
             if (Usr.userID == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"FlexContainer SignUpLogIn\"><div class=\"flexChild SignIn\"><a id=\"accountSignIn\" href=\"/Account-Login\">Log In</a></div>\r\n                    <div class=\"flexChild SignUp\"><a id=\"accountSignUp\" href=\"/Account-Creation\">Sign Up</a></div></div>");
#nullable restore
#line 29 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantHomePage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n        ");
            __builder.AddMarkupContent(12, "<h1 class=\"RestHeader\">Restaurant</h1>\r\n        ");
            __builder.AddMarkupContent(13, @"<table class=""Container""><tr><th>Item</th>
                <th>Description</th>
                <th>Price</th>
                <th>Add to Cart</th></tr>
            <tr><td>Burger</td>
                <td>Burger with pickles</td>
                <td>$9.89</td>
                <td><button><img class=""Plus"" src=""/Assets/RestaurantHomePage/plus.jpg"" alt></button></td></tr>
            <tr><td>Grilled Cheese</td>
                <td>Cheese with bread</td>
                <td>$7.99</td>
                <td><button><img class=""Plus"" src=""/Assets/RestaurantHomePage/plus.jpg"" alt></button></td></tr>
            <tr><td>Chicken Sandwich</td>
                <td>Chicken with bread</td>
                <td>$8.79</td>
                <td><button><img class=""Plus"" src=""/Assets/RestaurantHomePage/plus.jpg"" alt></button></td></tr></table>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private User Usr { get; set; }
    }
}
#pragma warning restore 1591
