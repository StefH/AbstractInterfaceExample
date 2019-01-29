using MyTestLibrary.Infrastructure.Email.Abstractions;
using MyTestLibrary.Infrastructure.Email.Gmail;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds services required for email logic.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddGmail(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailServiceForGmail>();

            return services;
        }
    }
}