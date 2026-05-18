using Telemetry.Shared;

namespace Telemetry.Analyzer
{
    public interface ITelemetryParser
    {
        public List<TelemetryEvent> Parse();
    }
}