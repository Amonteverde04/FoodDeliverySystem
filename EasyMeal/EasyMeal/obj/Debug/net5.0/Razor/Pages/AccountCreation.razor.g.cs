#pragma checksum "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6f7c275949364c9de2d48facee7ab3b177f610"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account-Creation")]
    public partial class AccountCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/AccountCreation.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "MainContainer");
            __builder.AddMarkupContent(3, "<div class=\"LogoContainer\"><a href><img class=\"logo\" src=\"/Assets/Logo.svg\" alt=\"EasyMeal\"></a></div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "UserTypeSelectorContainer");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "ButtonListContainer");
            __builder.OpenElement(8, "li");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "customerButton");
            __builder.AddAttribute(12, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                            onMouseClickCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "id", 
#nullable restore
#line 13 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                       idNameCustomer

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, "I want to order food");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "li");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "driverButton");
            __builder.AddAttribute(20, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                          onMouseClickDriver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "id", 
#nullable restore
#line 14 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                   idNameDriver

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, "I want to deliver food");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "li");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "restaurantButton");
            __builder.AddAttribute(28, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                              onMouseClickRestaurant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "id", 
#nullable restore
#line 15 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                           idNameRestaurant

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, "I represent a restaurant");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "AccountFieldsContainer");
            __builder.AddMarkupContent(34, "<h1 id=\"createAcc\">Create an account.</h1>\r\n        ");
            __builder.OpenElement(35, "form");
            __builder.AddAttribute(36, "class", "AccountFieldsForm");
            __builder.AddAttribute(37, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 21 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                    submitFields

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "FirstNameContainer");
            __builder.AddMarkupContent(40, "<label id=\"firstName\">First Name</label> <br>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "class", "FirstNameInput");
            __builder.AddAttribute(44, "required");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "LastNameContainer");
            __builder.AddMarkupContent(50, "<label id=\"lastName\">Last Name</label> <br>\r\n                ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "class", "LastNameInput");
            __builder.AddAttribute(54, "required");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "EmailPhonePassContainer");
            __builder.AddMarkupContent(60, "<label id=\"emailAddress\">Email Address</label> <br>\r\n                ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "email");
            __builder.AddAttribute(63, "class", "EmailInput");
            __builder.AddAttribute(64, "required");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                 email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, " <br>\r\n\r\n                ");
            __builder.AddMarkupContent(68, "<label id=\"phoneNumber\">Phone Number</label> <br>\r\n                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "number");
            __builder.AddAttribute(71, "class", "PhoneNumberInput");
            __builder.AddAttribute(72, "required");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                  phone

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => phone = __value, phone, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, " <br>\r\n\r\n                ");
            __builder.AddMarkupContent(76, "<label id=\"password\">Password</label> <br>\r\n                ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "password");
            __builder.AddAttribute(79, "class", "PassWordInput");
            __builder.AddAttribute(80, "minlength", "8");
            __builder.AddAttribute(81, "maxlength", "16");
            __builder.AddAttribute(82, "required");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                    password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.AddMarkupContent(86, "<div class=\"FormSubmitButtonContainer\"><button type=\"submit\" class=\"FormSubmitButton\">Create Account</button></div>\r\n            ");
            __builder.AddMarkupContent(87, "<p id=\"HaveAccountText\">Already a member? &nbsp&nbsp<a href=\"/Account-Login\">Sign In</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
       

    public string idNameCustomer { get; set; }

    public string idNameDriver { get; set; }

    public string idNameRestaurant { get; set; }

    private string firstName;
    private string lastName;
    private string email;
    private string phone;
    private string password;
    private int type = 1;
    private string mySetting = "";

    private string restaurantName { get; set; }

    // form input logic
    private void submitFields()
    {
        User newUser = new User(firstName, lastName, email, phone, password, type);
        newUser.connect = mySetting;
        //when decrypting use Encrypt.hashString(password)
        newUser.createAccount();
        // make sure the person is added to the table
        if (newUser.check == true)
        {

            NavigationManager.NavigateTo("/");

        }
    }

    // on load -> call this func
    private void initMethod()
    {
        idNameCustomer = "buttonActive";
        mySetting = _config.GetValue<string>("MySetting"); //on load get hidden connection string from appsettings.json
    }

    // user type button logic
    protected void onMouseClickCustomer(MouseEventArgs mouseEventArgs)
    {
        idNameDriver = string.Empty;
        idNameRestaurant = string.Empty;
        idNameCustomer = "buttonActive";
        type = 1;
    }

    protected void onMouseClickDriver(MouseEventArgs mouseEventArgs)
    {
        idNameCustomer = string.Empty;
        idNameRestaurant = string.Empty;
        idNameDriver = "buttonActive";
        type = 2;
    }

    protected void onMouseClickRestaurant(MouseEventArgs mouseEventArgs)
    {
        idNameDriver = string.Empty;
        idNameCustomer = string.Empty;
        idNameRestaurant = "buttonActive";
        type = 3;
    }

    // on load
    protected override async Task OnInitializedAsync()
    {
        // When page loads up, make sure customer is the primary selected button
        initMethod();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
    }
}
#pragma warning restore 1591
