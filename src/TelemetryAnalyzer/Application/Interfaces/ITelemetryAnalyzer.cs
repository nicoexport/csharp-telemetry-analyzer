using Telemetry.Shared;

namespace Telemetry.Analyzer
{
    public interface ITelemetryAnalyzer
    {
        public TelemetryReport Analyze(List<TelemetryEvent> events);
    }
}