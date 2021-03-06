#pragma checksum "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63373125f5186a596123dc94687f1cf142f9aee7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos2\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using BlazorCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas")]
    public partial class Personas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Personas</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n    <div class=\"col-12 text-right\">\r\n        <a href=\"personaform\">New</a>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<tr>\r\n        <th>ID</th>\r\n        <th>NAME</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
     if(onRespuesta != null && onRespuesta.Data !=null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
         foreach (var Element in onRespuesta.Data)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 25 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                 Element.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                 Element.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/personaform/" + (
#nullable restore
#line 28 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                                       Element.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/eliminar/" + (
#nullable restore
#line 29 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                                    Element.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\repos2\BlazorCrud\BlazorCrud\Pages\Personas.razor"
       
    public string url = "/api/Persona";
    public Data.Respuesta<List<Persona>> onRespuesta = new Data.Respuesta<List<Persona>>();

    protected override async Task OnInitializedAsync() =>
        onRespuesta = await Http.GetFromJsonAsync<Data.Respuesta<List<Persona>>>(url);

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
