namespace Telemetry.Analyzer
{
    public interface IReporter
    {
        public void Report(TelemetryReport report);
    }
}