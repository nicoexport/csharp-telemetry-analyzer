using Telemetry.Shared;

public class LogFileWriter : IDisposable
{
    private readonly StreamWriter _writer;

    public LogFileWriter(string path)
    {
        _writer = new StreamWriter(path);
    }

    public void WriteLine(TelemetryEvent e)
    {
        _writer.WriteLine(
            $"{e.Timestamp:o}|{e.Severity}|{e.Service}|{e.MachineId}|{e.Message}");
    }

    public void Write(IEnumerable<TelemetryEvent> events)
    {
        foreach (var e in events)
        {
            WriteLine(e);
        }
    }

    public void Dispose()
    {
        _writer.Dispose();
    }
}