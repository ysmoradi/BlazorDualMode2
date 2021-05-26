using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using BlazorDualMode2.Data;

namespace BlazorDualMode2.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddSingleton<WeatherForecastService>();

            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
