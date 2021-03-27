using CQRS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationDbContextConfiguration
    {
        public static IServiceCollection AddConfiguredDbContext(this IServiceCollection services,
                                                                IConfiguration configuration,
                                                                bool isDevEnvironment)
        {
            var connectionString = configuration.GetConnectionString("DbContext");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);

                if (isDevEnvironment)
                {
                    options.EnableDetailedErrors(true);
                    options.EnableSensitiveDataLogging(true);
                }
            });

            return services;
        }
    }
}
