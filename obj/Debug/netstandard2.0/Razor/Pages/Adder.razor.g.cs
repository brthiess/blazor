#pragma checksum "C:\Users\brad\blazor-test\Pages\Adder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2879836a18af1c7ed675d39c88178c3b9f24a44c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\brad\blazor-test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\brad\blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\brad\blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\brad\blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\brad\blazor-test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\brad\blazor-test\_Imports.razor"
using WebApplication2;

#line default
#line hidden
#line 7 "C:\Users\brad\blazor-test\_Imports.razor"
using WebApplication2.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/adder")]
    public class Adder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazor Test</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddMarkupContent(2, "\r\n");
#line 7 "C:\Users\brad\blazor-test\Pages\Adder.razor"
   foreach(var item in items){

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "li");
            __builder.AddContent(5, 
#line 8 "C:\Users\brad\blazor-test\Pages\Adder.razor"
         item

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#line 9 "C:\Users\brad\blazor-test\Pages\Adder.razor"
  }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "C:\Users\brad\blazor-test\Pages\Adder.razor"
                  addItem

#line default
#line hidden
            ));
            __builder.AddContent(10, "Add Item");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "C:\Users\brad\blazor-test\Pages\Adder.razor"
       
  List<string> items = new List<string>();
  public void addItem(){
    items.Add("Item");
    //Console.ReadLine();
  }

#line default
#line hidden
    }
}
#pragma warning restore 1591
