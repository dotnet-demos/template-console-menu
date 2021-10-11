using EasyConsole;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Option1
    {
        IDependency dependency;
        ILogger<Option1> logger;
        public Option1(IDependency dep,ILogger<Option1> logger)
        {
            dependency = dep;
            this.logger = logger;
        }
        async internal Task Execute()
        {
            logger.LogTrace($"{nameof(Option1)} : Start");
            await Task.Delay(1);
            logger.LogInformation($"Value from {nameof(IDependency)} is '{ dependency.Foo()}'");
        }
    }
}