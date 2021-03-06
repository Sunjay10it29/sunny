#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35de479e9b2fdbf3f53bc58544a76f2a6cad44f9"
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
    public partial class DateInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n  ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
                     !Property.CanWrite

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
                TextValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TextValue = __value, TextValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(6, "MM/dd/yyyy");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "<br>\n  ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "text-danger");
            __builder.AddContent(10, 
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
                             Property.ErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n  ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "text-warning");
            __builder.AddContent(14, 
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
                              Property.WarningText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n  ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "text-info");
            __builder.AddContent(18, 
#nullable restore
#line 7 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
                           Property.InformationText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Shared/DateInput.razor"
       
  [Parameter]
  public Csla.Blazor.IPropertyInfo Property { get; set; }
  [Parameter]
  public bool EmptyIsMin { get; set; } = true;
  [Parameter]
  public string FormatString { get; set; } = "MM/dd/yyyy";

  private Csla.SmartDate DateValue;

  private string TextValue
  {
    get
    {
      DateValue = new Csla.SmartDate((DateTime?)Property.Value, EmptyIsMin);
      DateValue.FormatString = FormatString;
      return DateValue.Text;
    }
    set
    {
      try
      {
        DateValue.Text = value;
      }
      catch (ArgumentException)
      { /* invalid text entry, don't update value */ }
      if (DateValue.IsEmpty)
        Property.Value = null;
      else
        Property.Value = DateValue.Date;
    }
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
