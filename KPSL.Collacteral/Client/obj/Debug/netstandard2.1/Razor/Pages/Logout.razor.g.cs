#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67253bcb3e69c238b7be96853005f0ea6344517"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Logout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Logout.razor"
using Csla.Blazor.Client.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Logout</h3>\n\nAre you sure you want to log out?\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Logout.razor"
                  LogoutUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddContent(4, "Logout");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Logout.razor"
       
  private void LogoutUser()
  {
    var identity = new ClaimsIdentity();
    userService.CurrentUser = new System.Security.Claims.ClaimsPrincipal(identity);
    base.OnInitialized();
    StateHasChanged();
    NavigationManager.NavigateTo("/");
      }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CslaUserService userService { get; set; }
    }
}
#pragma warning restore 1591
