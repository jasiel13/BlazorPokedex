#pragma checksum "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443c8572eb388359fc34d5e018c10c59c5c443cc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPokedex.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using BlazorPokedex.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\_Imports.razor"
using BlazorPokedex.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class PokemonGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
 if (Pokemons == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Cargando...</em></p>");
#nullable restore
#line 6 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
#nullable restore
#line 10 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
         for (int i = 0; i < NumberOfRows; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 14 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                 foreach (var poke in Pokemons.Skip(i * 6).Take(6))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card" + " pokeCard" + " mb-4" + " bg-" + (
#nullable restore
#line 16 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                        poke.Types.FirstOrDefault().PokemonType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.OpenElement(8, "h4");
            __builder.AddAttribute(9, "class", "card-title");
            __builder.AddContent(10, 
#nullable restore
#line 18 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                    poke.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                            ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 19 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                       poke.Sprite.Front

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "img-fluid");
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 19 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                                                  poke.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "moreinfo");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "badge" + " border" + " rounded-pill" + " bg-" + (
#nullable restore
#line 23 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                                        poke.Types.FirstOrDefault().PokemonType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/pokeDetails/" + (
#nullable restore
#line 24 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                                                      poke.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "style", "text-decoration:none");
            __builder.AddAttribute(24, "class", "text-white");
            __builder.AddContent(25, " Detalles");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Jasiel\Downloads\BlazorPokedex\BlazorPokedex.Client\Pages\PokemonGrid.razor"
       

    [Parameter]
    public IEnumerable<Pokemon> Pokemons { get; set; }

    [Parameter]
    public int NumberOfRows { get; set; }//nunca va haber mas filas que de numero asignado por ejemplo 5

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
