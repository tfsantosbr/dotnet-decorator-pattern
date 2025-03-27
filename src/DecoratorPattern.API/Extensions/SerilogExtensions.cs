using Serilog;

namespace DecoratorPattern.API.Extensions;

public static class SerilogExtensions
{
    public static void AddSerilogServices(this IServiceCollection services)
    {
        services.AddSerilog((services, lc) => lc
            .ReadFrom.Services(services)
            .Enrich.FromLogContext()
            .WriteTo.Console()
        );
    }
}