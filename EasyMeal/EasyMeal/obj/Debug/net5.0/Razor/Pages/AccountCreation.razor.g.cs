#pragma checksum "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87265be366b688b6953b5d99bd65cd0cdd7ee08d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account-Creation")]
    public partial class AccountCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "MainContainer");
            __builder.AddMarkupContent(2, "<div class=\"LogoContainer\"><a href><img class=\"logo\" src=\"/Assets/Logo.svg\" alt=\"EasyMeal\"></a></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "UserTypeSelectorContainer");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "ButtonListContainer");
            __builder.OpenElement(7, "li");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "customerButton");
            __builder.AddAttribute(11, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                            onMouseClickCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "id", 
#nullable restore
#line 11 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                       idNameCustomer

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, "I want to order food");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "li");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "driverButton");
            __builder.AddAttribute(19, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                          onMouseClickDriver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "id", 
#nullable restore
#line 12 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                   idNameDriver

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, "I want to deliver food");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "li");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "restaurantButton");
            __builder.AddAttribute(27, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                              onMouseClickRestaurant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "id", 
#nullable restore
#line 13 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                                                           idNameRestaurant

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, "I represent a restaurant");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "AccountFieldsContainer");
            __builder.AddMarkupContent(33, "<h1 id=\"createAcc\">Create an account.</h1>\r\n        ");
            __builder.OpenElement(34, "form");
            __builder.AddAttribute(35, "class", "AccountFieldsForm");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "FirstNameContainer");
            __builder.AddMarkupContent(38, "<label id=\"firstName\">First Name</label> <br>\r\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "FirstNameInput");
            __builder.AddAttribute(42, "required");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "LastNameContainer");
            __builder.AddMarkupContent(48, "<label id=\"lastName\">Last Name</label> <br>\r\n                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "class", "LastNameInput");
            __builder.AddAttribute(52, "required");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
             if (@idNameCustomer == "buttonActive" || idNameDriver == "buttonActive")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "EmailPhonePassContainer");
            __builder.AddMarkupContent(57, "<label id=\"emailAddress\">Email Address</label> <br>\r\n                    ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "email");
            __builder.AddAttribute(60, "class", "EmailInput");
            __builder.AddAttribute(61, "required");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                     email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, " <br>\r\n\r\n                    ");
            __builder.AddMarkupContent(65, "<label id=\"phoneNumber\">Phone Number</label> <br>\r\n                    ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "number");
            __builder.AddAttribute(68, "class", "PhoneNumberInput");
            __builder.AddAttribute(69, "required");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                      phone

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => phone = __value, phone, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, " <br>\r\n\r\n                    ");
            __builder.AddMarkupContent(73, "<label id=\"password\">Password</label> <br>\r\n                    ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "password");
            __builder.AddAttribute(76, "class", "PassWordInput");
            __builder.AddAttribute(77, "minlength", "8");
            __builder.AddAttribute(78, "maxlength", "16");
            __builder.AddAttribute(79, "required");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                        password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
             if (@idNameRestaurant == "buttonActive")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "EmailPhonePassContainer");
            __builder.AddMarkupContent(84, "<label id=\"restaurantName\">Restaurant Name</label> <br>\r\n                    ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "RestaurantNameInput");
            __builder.AddAttribute(88, "required");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                    restaurantName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => restaurantName = __value, restaurantName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, " <br>\r\n\r\n                    ");
            __builder.AddMarkupContent(92, "<label id=\"emailAddress\">Email Address</label> <br>\r\n                    ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "email");
            __builder.AddAttribute(95, "class", "EmailInput");
            __builder.AddAttribute(96, "required");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                     email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, " <br>\r\n\r\n                    ");
            __builder.AddMarkupContent(100, "<label id=\"password\">Password</label> <br>\r\n                    ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "password");
            __builder.AddAttribute(103, "class", "PassWordInput");
            __builder.AddAttribute(104, "minlength", "8");
            __builder.AddAttribute(105, "maxlength", "16");
            __builder.AddAttribute(106, "required");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                        password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "FormSubmitButtonContainer");
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "type", "submit");
            __builder.AddAttribute(113, "class", "FormSubmitButton");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
                                                                         submitFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(115, "Create Account");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.AddMarkupContent(117, "<p id=\"HaveAccountText\">Already a member? &nbsp&nbsp<a href>Sign In</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\awsom\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
       

    public string idNameCustomer { get; set; }

    public string idNameDriver { get; set; }

    public string idNameRestaurant { get; set; }

    private string firstName { get; set; }

    private string lastName { get; set; }

    private string email { get; set; }

    private string phone { get; set; }

    private string password { get; set; }

    private string restaurantName { get; set; }

    // will hold connection string
    private string mySetting = "";

    // form input logic
    private void submitFields()
    {
        SqlConnection con = new SqlConnection(mySetting);


        if (idNameCustomer == "buttonActive")
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customertest(FirstName, LastName, CustomerEail, PhoneNumber, Password) VALUES (@firstName, @lastName, @email, @phone, @password)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);
            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                Console.WriteLine("Account created!");
            }
            else
            {
                Console.WriteLine("Error, account not created!");
            }
            con.Dispose();
        }
        else if (idNameDriver == "buttonActive")
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DriverTable(FirstName, LastName, DriverEmail, PhoneNumber, Password) VALUES (@firstName, @lastName, @email, @phone, @password)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);
            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                Console.WriteLine("Account created!");
            }
            else
            {
                Console.WriteLine("Error, account not created!");
            }
            con.Dispose();

        }
        else if (idNameRestaurant == "buttonActive")
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO RestaurantTable(FirstName, LastName, RestaurantName, RestaurantEmail, Password) VALUES (@firstName, @lastName, @restaurantName, @restaurantEmail, @password)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@restaurantName", restaurantName);
            cmd.Parameters.AddWithValue("@restaurantEmail", email);
            cmd.Parameters.AddWithValue("@password", password);
            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                Console.WriteLine("Account created!");
            }
            else
            {
                Console.WriteLine("Error, account not created!");
            }
            con.Dispose();
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
    }

    protected void onMouseClickDriver(MouseEventArgs mouseEventArgs)
    {
        idNameCustomer = string.Empty;
        idNameRestaurant = string.Empty;
        idNameDriver = "buttonActive";
    }

    protected void onMouseClickRestaurant(MouseEventArgs mouseEventArgs)
    {
        idNameDriver = string.Empty;
        idNameCustomer = string.Empty;
        idNameRestaurant = "buttonActive";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
    }
}
#pragma warning restore 1591
