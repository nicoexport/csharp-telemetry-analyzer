namespace Telemetry
{    
    public interface ITelemetryAnalyzer
    {
        public TelemetryReport Analyze(List<TelemetryEvent> events);
    }
}