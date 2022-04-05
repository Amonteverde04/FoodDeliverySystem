// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account-Creation")]
    public partial class AccountCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\tomca\Documents\GitHub\FoodDeliverySystem\EasyMeal\EasyMeal\Pages\AccountCreation.razor"
       

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
