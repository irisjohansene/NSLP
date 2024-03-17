using Serilog.Events;
using Serilog.Formatting.Json;
using Serilog;
using Serilog.Core;

namespace NSLPWebApi
{
    public class SeriLogger
    {
        private readonly Logger _logger = new LoggerConfiguration()
                                    .WriteTo.File(new JsonFormatter(),
                                                  "Logs/nslp-logs.json",
                                                  restrictedToMinimumLevel: LogEventLevel.Warning)
                                    .WriteTo.File("Logs/nslp-logs.logs",
                                                  rollingInterval: RollingInterval.Day)
                                    .MinimumLevel.Debug()
                                    .CreateLogger();
        public Logger GetLogger() => _logger;
    }
}
