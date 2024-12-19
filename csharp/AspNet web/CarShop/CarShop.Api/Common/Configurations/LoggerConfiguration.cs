using Serilog;

namespace CarShop.Api.Common.Configurations;
public static class LoggerConfiguration
{
    public static void ConfigureLogger(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((hostingContext, loggerConfiduration) =>
                         loggerConfiduration.ReadFrom.Configuration(hostingContext.Configuration));
    }
}
