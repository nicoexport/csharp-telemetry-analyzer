using Telemetry.Shared;

public class TelemetryEventGenerator
{
    private TimestampGenerator timestampGenerator = new(DateTime.UtcNow);
    private SeverityGenerator severityGenerator = new();
    private ServiceGenerator serviceGenerator = new();
    private MachineIdGenerator machineGenerator = new();
    private MessageGenerator messageGenerator = new();

    public IEnumerable<TelemetryEvent> Generate(int count)
    {
        for(int i = 0; i < count; i++)
        {
            yield return GenerateEvent();
        }
    }

    private TelemetryEvent GenerateEvent()
    {
        TelemetryEvent e = new();
        e.Timestamp = timestampGenerator.Next();
        e.Severity = severityGenerator.Generate();
        e.Service = serviceGenerator.Generate();
        e.MachineId = machineGenerator.Generate(e.Service);
        e.Message = messageGenerator.Generate(e.Service, e.Severity);
        return e;
    }
}