#pragma checksum "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c8b5ae0ed622d841bdb870e632be6e116758de"
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
#line 3 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminar/{Id:int}")]
    public partial class DeletePerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DeletePerson</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Deseas eleminar el ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
                       Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
                      Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\repos2\BlazorCrud\BlazorCrud\Pages\DeletePerson.razor"
       
    [Parameter]
    public int Id { get; set; }
    public string url = "/api/Persona";

    Respuesta<object> oRespuesta = new Respuesta<object>();

    private async Task Delete()
    {
        var response = await Http.DeleteAsync(url + "/" + Id);
        oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        NavigationManager.NavigateTo("/personas");
    }

    private void Cancel() => NavigationManager.NavigateTo("/personas");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591