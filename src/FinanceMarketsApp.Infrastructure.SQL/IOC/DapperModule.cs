using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceMarketsApp.Infrastructure.SQL.IOC
{
    public static class DapperModule
    {
        public static IServiceCollection AddDapperModule(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            return services;
        }
    }
}
