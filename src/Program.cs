using EasyConsole;
using System.Threading;
using System.Threading.Tasks;
using DotNet.Helpers;
namespace ConsoleApp
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await PrintOptionsAndRunTestAsync();
        }
        async static Task PrintOptionsAndRunTestAsync()
        {
            bool canContinue = true;
            while (canContinue)
            {
                var menu = new Menu()
                    .Add("Menu option 1", async (token) => await Option1.Execute())
                    .AddSync("Exit", () => canContinue = false);
                await menu.Display(CancellationToken.None);
            }
        }
    }
}
