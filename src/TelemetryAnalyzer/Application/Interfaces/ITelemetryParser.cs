using Telemetry.Shared;

namespace Telemetry;

public interface ITelemetryParser
{
    public List<TelemetryEvent> Parse();
}