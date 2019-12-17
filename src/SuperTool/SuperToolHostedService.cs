namespace SuperTool
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    public class SuperToolHostedService : IHostedService
    {
        private readonly ILogger<SuperToolHostedService> _logger;

        public SuperToolHostedService(ILogger<SuperToolHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Hi from the command line!");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Bye from the command line!");
            return Task.CompletedTask;
        }
    }
}
