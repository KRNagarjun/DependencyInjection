using System.Threading.Tasks;
using DependencyInjectionDemo.Interfaces;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionDemo.Services
{
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }

        public Task WriteMessage(string message)
        {
            _logger.LogInformation(
                "MyDependency.WriteMessage called. Message: {Message}",
                message);

            return Task.FromResult(0);
        }
    }
}
