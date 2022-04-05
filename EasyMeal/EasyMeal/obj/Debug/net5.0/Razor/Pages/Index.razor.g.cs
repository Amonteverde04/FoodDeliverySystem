#pragma checksum "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5b23b020c8c0c329476a8c4e51bba0247982c2"
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
#line 1 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using EasyMeal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using EasyMeal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/LandingPage.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"page\"><div class=\"Hero\"><div class=\"LogoContainer\"><img class=\"Logo\" src=\"/Assets/LandingPage/Logo.svg\"></div>\r\n        <div class=\"FlexContainer SignUpLogIn\"><div class=\"flexChild SignIn\"><a id=\"accountSignIn\" href=\"/Account-Login\">Log In</a></div>\r\n            <div class=\"flexChild SignUp\"><a id=\"accountSignUp\" href=\"/Account-Creation\">Sign Up</a></div></div>\r\n        <div class=\"HeroSearchContainer\"><form class=\"SearchForm\" action=\"/\"><button class=\"Pin\" type=\"button\"><img class=\"PinSvg\" src=\"/Assets/LandingPage/Pin.svg\"></button> \r\n                <input class=\"SearchBar\" type=\"text\" placeholder=\"Get started by adding your drop off location!\" name=\"search\"></form></div></div>\r\n    <div class=\"InfoSection1\"><div class=\"TextHolderSection1\"><div class=\"Section1TitleHolder\"><h3>Find local restaurants at the press of a button.</h3></div>\r\n            <div class=\"Section1Paragraph1Holder\"><p>\r\n                    EasyMeal makes it easy for anyone to get food when they want it.\r\n                </p></div>\r\n            <div class=\"Section1Paragraph2Holder\"><p>\r\n                    Search through hundreds of options by putting your desired drop-off location in the search bar above or by clicking the location icon to share your current location.\r\n                </p></div></div>\r\n        <img class=\"MapPicture\" src=\"/Assets/LandingPage/Map-Pic.png\" alt=\"Map\"></div>\r\n    <div class=\"InfoSection2\"><div class=\"TextHolderSection2\"><div class=\"Section2TitleHolder\"><h3>EasyMeal does the hardwork so you don’t have to.</h3></div>\r\n            <div class=\"Section2Paragraph1Holder\"><p>\r\n                    Our mission is to fast-track the dining experience for the everyday person.\r\n                </p></div>\r\n            <div class=\"Section2Paragraph2Holder\"><p>\r\n                    Whether you’re a busy stay at home mom, hardworking professional or hyper-focused freelancer, you will be enjoying delicious local cuisine within minutes*. Get the food you want delivered to where ever you need it.\r\n                </p></div></div>\r\n            <img class=\"GuyPicture\" src=\"/Assets/LandingPage/Guy-pic.png\" alt=\"Guy taking picture of food\"></div>\r\n        <div class=\"Footer\"><div class=\"FlexContainerFoot SignUpLogIn\"><div class=\"flexChildFoot About\"><a id=\"footerAbout\" href=\"/\">About</a></div>\r\n                <div class=\"flexChildFoot Contact\"><a id=\"footerContact\" href=\"/\">Contact</a></div>\r\n                <div class=\"flexChildFoot List\"><a id=\"footerList\" href=\"/Restaurant-List\">List</a></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
