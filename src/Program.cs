using System.Threading.Tasks;
using DotNet.Helpers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    class Program
    {
        async static Task Main (string[] args) =>
            await Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostBuilderContext, services) =>
                {
                    services.AddHostedService<MenuService>();
                    services.AddScoped<IDependency, Dependency>();
                    services.AddSingleton<Option1>();
                })
                //.UseConsoleLifetime() // This may be used when running inside container. But we dont really run an interative menu program in container.
                .Build()
                .RunAsync();
    }
}