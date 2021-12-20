using BlazorPokedex.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //aqui es de donde va obtener las peticiones http en lugar de resivirlas el servidor iis express localhost las va a recibir de un api externa
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/") });
            
            builder.Services.AddScoped<IPokeApiClient, PokeApiClient>();

            await builder.Build().RunAsync();
        }
    }
}
