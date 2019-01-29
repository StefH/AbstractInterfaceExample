using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyTestLibrary.Infrastructure.Email.Abstractions;

namespace ConsoleAppInterfaceDesignTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ServiceCollection
            var services = new ServiceCollection();

            // Add logging & services
            services.AddLogging(builder =>
            {
                builder.SetMinimumLevel(LogLevel.Trace);
                builder.AddConsole();
                builder.AddDebug();
            });

            // Add email (outlook)
            services.AddOutlook();

            var serviceProvider = services.BuildServiceProvider();

            // Resolve ILoggerFactory and ILogger via DI
            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Program>();
            logger.LogInformation("Going to send email...");

            // Resolve IEmailService via DI
            var service = serviceProvider.GetService<IEmailService>();

            // Send !
            service.Send();
        }
    }
}