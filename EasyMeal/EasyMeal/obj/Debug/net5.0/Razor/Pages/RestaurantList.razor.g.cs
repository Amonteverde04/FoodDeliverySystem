#pragma checksum "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e261dfe94ac23a2d9fa8460bcb4b7f9acec947eb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Restaurant-List")]
    public partial class RestaurantList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/RestaurantList.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "RestuarantList");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "Header");
            __builder.AddMarkupContent(7, @"<div class=""Search""><form class=""SearchForm"" action=""/Restaurant-List""><button class=""Glass"" type=""button""><img class=""SearchGlassSvg"" src=""/Assets/RestaurantList/SearchGlass.svg""></button>
                    <input class=""SearchBar"" type=""text"" placeholder=""Search"" name=""search""></form></div>
            ");
            __builder.AddMarkupContent(8, "<div class=\"LogoContainer\"><a href><img class=\"logo\" src=\"/Assets/RestaurantList/EasyMealLogo.svg\" alt=\"EasyMeal\"></a></div>");
#nullable restore
#line 22 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
             if (Usr.userID == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<div class=\"FlexContainer SignUpLogIn\"><div class=\"flexChild SignIn\"><a id=\"accountSignIn\" href=\"/Account-Login\">Log In</a></div>\r\n                    <div class=\"flexChild SignUp\"><a id=\"accountSignUp\" href=\"/Account-Creation\">Sign Up</a></div></div>");
#nullable restore
#line 28 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "FlexContainer SignUpLogIn");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "SignOut");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
                                                      Usr.logOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Sign Out");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "SectionGridContainer");
#nullable restore
#line 38 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
             for (int i = 0; i < restNameList.Count(); i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "GridItem");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/Restaurant-Home-page");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "RestThumbNail");
            __builder.AddAttribute(25, "src", "/Assets/RestaurantList/restaurant-building.svg");
            __builder.AddAttribute(26, "alt", 
#nullable restore
#line 42 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
                                                                                                              restNameList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "RestName");
            __builder.AddContent(30, 
#nullable restore
#line 43 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
                                             restNameList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "RestType");
            __builder.AddContent(33, 
#nullable restore
#line 43 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
                                                                                     restTypeList[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\RestaurantList.razor"
       
    string restName = "";
    string restType = "";
    string mySetting = "";
    private DataUploadModel theData = new DataUploadModel();
    private List<string> restNameList = new List<string>();
    private List<string> restTypeList = new List<string>();


    // on load -> call this func
    private void initMethod()
    {
        mySetting = _config.GetValue<string>("MySetting"); //on load get hidden connection string from appsettings.json
        theData.connect = mySetting;
        restNameList = theData.getAllRestaurantNames();
        restTypeList = theData.getAllRestaurantTypes();
    }

    // on load
    protected override async Task OnInitializedAsync()
    {
        initMethod();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private User Usr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
    }
}
#pragma warning restore 1591
