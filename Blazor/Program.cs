using Blazor.OS;
using Core.Lib.OS;
using Core.MVVM;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            };

            SettingsStorage.CurrentValues = await httpClient.GetFromJsonAsync<SettingsStorage.Values>("settings.json");

            DependencyService.Register<SettingsStorage, ISettingsStorage>();
            DependencyService.Register<NavigationService, INavigationService>(DependencyService.ServiceLifetime.Singleton);
            await builder.Build().RunAsync();
        }
    }
}
