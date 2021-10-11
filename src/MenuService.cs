using EasyConsole;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp
{
    internal class MenuService : BackgroundService
    {
        public Option1 Option1 { get; init; }
        public MenuService(Option1 opt1)
        {
            Option1 = opt1;
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var menu = new Menu()
                .Add("Menu option 1", async (token) => await Option1.Execute())
                .AddSync("Exit", () => Environment.Exit(0));
            await menu.Display(CancellationToken.None);
            await base.StartAsync(stoppingToken);
        }
    }
}