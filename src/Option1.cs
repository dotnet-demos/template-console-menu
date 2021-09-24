using EasyConsole;
using System;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Option1
    {
        async internal static Task Execute()
        {
            await Task.Delay(1);
            Output.WriteLine(ConsoleColor.Green, "Executed");
        }
    }
}
