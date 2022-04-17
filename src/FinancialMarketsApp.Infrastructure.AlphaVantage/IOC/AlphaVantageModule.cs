using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace FinancialMarketsApp.Infrastructure.AlphaVantage.IOC {
    public static class AlphaVantageModule 
    {
        public static IServiceCollection AddAlphaVantageModule(this IServiceCollection services)
        {

            return services;
        }

    }
}
