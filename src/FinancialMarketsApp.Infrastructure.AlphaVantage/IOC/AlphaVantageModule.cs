using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialMarketsApp.Core.Interfaces;
using FinancialMarketsApp.Infrastructure.AlphaVantage.Clients;
using FinancialMarketsApp.Infrastructure.AlphaVantage.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FinancialMarketsApp.Infrastructure.AlphaVantage.IOC
{
    public static class AlphaVantageModule
    {
        public static IServiceCollection AddAlphaVantageModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAlphaVantageOptions(configuration);
            services.AddHttpClient<IAlphaVantageClient, AlphaVantageClient>(client =>
            {
                var options = services.BuildServiceProvider().GetRequiredService<IOptions<AlphaVantageOptions>>().Value;

                client.BaseAddress = new Uri(options.BaseAddress);
            });

            return services;
        }

        private static IServiceCollection AddAlphaVantageOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<AlphaVantageOptions>().Configure(options =>
            {
                configuration.GetSection(AlphaVantageOptions.Section).Bind(options);
            });

            return services;
        }

    }
}
