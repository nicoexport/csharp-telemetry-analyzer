using Telemetry.Shared;

public class LogFileWriter
{
    public void WriteLine(StreamWriter writer, TelemetryEvent ev)
    {
        writer.WriteLine($"{ev.Timestamp:o}|{ev.Severity}|{ev.Service}|{ev.MachineId}|{ev.Message}");        
    } 
}