namespace Telemetry
{
    public interface IConsoleReporter
    {
        public void Print(TelemetryReport report);
    }
}