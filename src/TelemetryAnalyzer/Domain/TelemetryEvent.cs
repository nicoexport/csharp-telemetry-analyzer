namespace Telemetry
{
    public class TelemetryEvent
    {
        public DateTime Timestamp {get; set;} = default;
        public string Message {get; set;} = "";
        public Severity Severity {get; set;} = default;    
    }
}