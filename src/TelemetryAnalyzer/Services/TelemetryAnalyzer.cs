namespace Telemetry
{
    public class TelemetryAnalyzer : ITelemetryAnalyzer
    {
        public TelemetryReport Analyze(List<TelemetryEvent> events)
        {
            return new TelemetryReport
            {
                Total = events.Count,
                Errors = events.Count(e => e.Severity == Severity.Error),
                Critical = events.Count(e => e.Severity == Severity.Critical)
            };
        }
    }
}