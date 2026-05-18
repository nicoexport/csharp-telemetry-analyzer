namespace Telemetry;

public interface IReporter
{
    public void Report(TelemetryReport report);
}