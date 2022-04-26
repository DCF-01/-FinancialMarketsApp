﻿using FinancialMarketsApp.MVC.Options;

namespace FinancialMarketsApp.MVC.IOC
{
    public static class MVCModule
    {
        public static IServiceCollection AddMvcModule(this IServiceCollection services, ConfigurationManager configuration)
        {
            string configPath = configuration.GetSection("UserConfig").Value;
            configuration.AddJsonFile(configPath);

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
