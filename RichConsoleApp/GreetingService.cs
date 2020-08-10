using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// using DI, Logging, Settings in concole app

namespace RichConsoleApp
{
    public class GreetingService : IGreetingService
    {
        private readonly IConfiguration _config;
        private readonly ILogger<GreetingService> _logger;

        public GreetingService(IConfiguration config, ILogger<GreetingService> logger)
        {
            _config = config;
            _logger = logger;
        }
        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
