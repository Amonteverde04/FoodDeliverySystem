#pragma checksum "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5926748687160c3e01176645ca083aa4038465a8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account-Preferences")]
    public partial class AccountPreferences : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/AccountPreferences.css\" rel=\"stylesheet\">\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "Preferences");
            __builder.AddMarkupContent(5, "<div class=\"Header\"><div class=\"LogoContainer\"><a href><img class=\"logo\" src=\"/Assets/Logo.svg\" alt=\"EasyMeal\"></a></div>\r\n            <h2 class=\"HeaderTitle\">Account Preferences</h2></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "PreferencesContainer");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "InfoContainer");
            __builder.AddMarkupContent(10, "<h2 class=\"Section\">Personal Information</h2>\r\n                ");
            __builder.AddMarkupContent(11, @"<div class=""PFPContainer""><div class=""PFPBorder""><div class=""PFPCircle""><img class=""PFP"" src=""/Assets/AccountPreferences/DefaultPFP.svg"" alt=""PFP""></div></div>
                    <form class=""PFPForm""><label for=""pictureUpload"">Select a picture:</label>
                        <input type=""file"" id=""pictureUpload"" name=""pictureUpload"" accept=""image/*"">
                        <br><br>
                        <input type=""submit""></form></div>
                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "UserInfoContainer");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "class", "AccountFieldsForm");
            __builder.AddAttribute(16, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 31 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                               submitFields

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "FirstNameContainer");
            __builder.AddMarkupContent(19, "<label id=\"inputLabel\">First Name</label> <br>\r\n                            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "FirstNameInput");
            __builder.AddAttribute(23, "required");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                            firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "LastNameContainer");
            __builder.AddMarkupContent(29, "<label id=\"inputLabel\">Last Name</label> <br>\r\n                            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "LastNameInput");
            __builder.AddAttribute(33, "required");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                            lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "EmailPhoneContainer");
            __builder.AddMarkupContent(39, "<label id=\"inputLabel\">Email Address</label> <br>\r\n                            ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "email");
            __builder.AddAttribute(42, "class", "EmailInput");
            __builder.AddAttribute(43, "required");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                             email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, " <br>\r\n\r\n                            ");
            __builder.AddMarkupContent(47, "<label id=\"inputLabel\">Phone Number</label> <br>\r\n                            ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "number");
            __builder.AddAttribute(50, "class", "PhoneNumberInput");
            __builder.AddAttribute(51, "required");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                              phone

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => phone = __value, phone, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, " <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.AddMarkupContent(56, "<h2 class=\"Section2\">Address Information</h2>\r\n                        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "AddressContainer");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "StreetCityContainer");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "StreetNameContainer");
            __builder.AddMarkupContent(63, "<label id=\"inputLabel\">Street</label> <br>\r\n                                    ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "StreetNameInput");
            __builder.AddAttribute(67, "required");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                                    street

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => street = __value, street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "CityNameContainer");
            __builder.AddMarkupContent(73, "<label id=\"inputLabel\">City</label> <br>\r\n                                    ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "CityNameInput");
            __builder.AddAttribute(77, "required");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                                    city

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city = __value, city));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "StateZipContainer");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "StateNameContainer");
            __builder.AddMarkupContent(85, "<label id=\"inputLabel\">State</label> <br>\r\n                                    ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "text");
            __builder.AddAttribute(88, "class", "StateNameInput");
            __builder.AddAttribute(89, "required");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                                    state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => state = __value, state));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "ZipContainer");
            __builder.AddMarkupContent(95, "<label id=\"inputLabel\">Zip Code</label> <br>\r\n                                    ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "class", "ZipInput");
            __builder.AddAttribute(99, "required");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
                                                                    zip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => zip = __value, zip));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.AddMarkupContent(103, "<h2 class=\"Section3\">Billing Information</h2>\r\n                        ");
            __builder.AddMarkupContent(104, "<div class=\"FormSubmitButtonContainer\"><button type=\"submit\" class=\"FormSubmitButton\">Create Account</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountPreferences.razor"
       
    private string firstName;
    private string lastName;
    private string email;
    private string phone;
    private string street;
    private string city;
    private string state;
    private string zip;

    public void submitFields()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
