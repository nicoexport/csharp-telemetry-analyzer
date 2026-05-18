using Telemetry.Shared;

public class LogFileWriter
{
    public void Write(string path, IEnumerable<TelemetryEvent> events)
    {
        using var writer = new StreamWriter(path);

        foreach (var e in events)
        {
            writer.WriteLine($"{e.Timestamp:o}|{e.Severity}|{e.Service}|{e.MachineId}|{e.Message}");
        }
    }
}