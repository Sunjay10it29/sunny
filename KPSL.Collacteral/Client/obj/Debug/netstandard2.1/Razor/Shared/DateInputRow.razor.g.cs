#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7073a46239980a360db07ab80fe1f66c2e81e594"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Shared
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
    public partial class DateInputRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
 if (Property.CanRead)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "  ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "td");
            __builder.AddContent(4, 
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
          Property.FriendlyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\n      ");
            __builder.OpenComponent<KPSL.Collacteral.Client.Shared.DateInput>(8);
            __builder.AddAttribute(9, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Csla.Blazor.IPropertyInfo>(
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
                            Property

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "EmptyIsMin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
                                                   EmptyIsMin

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 9 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInputRow.razor"
       
  [Parameter]
  public Csla.Blazor.IPropertyInfo Property { get; set; }
  [Parameter]
  public bool EmptyIsMin { get; set; } = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
