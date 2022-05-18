using FinanceMarketsApp.Infrastructure.SQL.Context;
using Microsoft.Extensions.DependencyInjection;
using FluentMigrator.SqlServer;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using FinanceMarketsApp.Infrastructure.SQL.Options;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using FinanceMarketsApp.Infrastructure.SQL.Migrations;

namespace FinanceMarketsApp.Infrastructure.SQL.IOC
{
    public static class DapperModule
    {
        public static IServiceCollection AddDapperModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDapperOptions(configuration)
                .AddSingleton<DapperContext>()
                .ConfigureDapper(configuration);
            return services;
        }


        private static IServiceProvider ConfigureDapper(this IServiceCollection services, IConfiguration configuration)
        {
            return new ServiceCollection()
                    .AddFluentMigratorCore()
                    .ConfigureRunner(r => r
                        .AddSqlServer()
                        .WithGlobalConnectionString(configuration.Get<SQLOptions>().ConnectionString)
                        .ScanIn(typeof(M0001_CreateUserTable).Assembly).For.Migrations())
                    .AddLogging(lb => lb.AddFluentMigratorConsole())
                    .BuildServiceProvider(false);
        }

        private static IServiceCollection AddDapperOptions(this IServiceCollection services, IConfiguration configuration)
        {

            services
                .AddOptions<SQLOptions>()
                .Configure(options => configuration.GetSection(SQLOptions.Section).Bind(options));

            return services;
        }

        public static void UpdateDatabase(IServiceCollection services)
        {
            var runner = services.BuildServiceProvider().GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }
    }
}
