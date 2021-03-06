// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "D:\repos2\BlazorCrud\BlazorCrud\Pages\PersonaForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos2\BlazorCrud\BlazorCrud\Pages\PersonaForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos2\BlazorCrud\BlazorCrud\Pages\PersonaForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personaform")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/personaform/{Id:int}")]
    public partial class PersonaForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\repos2\BlazorCrud\BlazorCrud\Pages\PersonaForm.razor"
       
    [Parameter]
    public int Id { get; set; }

    Persona oPersona = new Persona();
    Respuesta<object> oRespuesta = new Respuesta<object>();
    Respuesta<Persona> oRespuestaPersona = new Respuesta<Persona>();
    public string url = "/api/Persona";

    private async Task Save()
    {
        if(Id != 0)
        {
            var response = await Http.PutAsJsonAsync<Persona>(url, oPersona);
            oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        }
        else
        {
            var response = await Http.PostAsJsonAsync<Persona>(url, oPersona);
            oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        }

        NavigationManager.NavigateTo("/personas");
    }

    protected override async Task OnInitializedAsync()
    {
        if(Id != 0)
        {
        oRespuestaPersona = await Http.GetFromJsonAsync<Data.Respuesta<Persona>>(url + "/" + Id);
        oPersona = oRespuestaPersona.Data;

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
