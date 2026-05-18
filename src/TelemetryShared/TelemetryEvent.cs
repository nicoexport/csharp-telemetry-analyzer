namespace Telemetry.Shared;

public class TelemetryEvent
{
    public DateTime Timestamp {get; set;} = default;
    public string Message {get; set;} = "";
    public Severity Severity {get; set;} = default;    

    public TelemetryEvent(DateTime timestamp, string message, Severity severity)
    {
        Timestamp = timestamp;
        Message = message;
        Severity = severity;
    }
}
