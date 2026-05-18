namespace Telemetry.Shared;

public class TelemetryEvent
{
    public DateTime Timestamp {get; set;} = default;
    public Severity Severity {get; set;} = default;    
    public Service Service {get; set; } = default;
    public string MachineId {get; set; } = "";
    public string Message {get; set;} = "";

    public TelemetryEvent(DateTime timestamp, string message, Severity severity)
    {
        Timestamp = timestamp;
        Message = message;
        Severity = severity;
    }

    public TelemetryEvent()
    {
        
    }
}
