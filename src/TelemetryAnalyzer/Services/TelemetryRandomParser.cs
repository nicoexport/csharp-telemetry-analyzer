using Telemetry.Shared;

namespace Telemetry;

public class TelemetryRandomParser : ITelemetryParser
{
    private static string[] errorMessages =
    [
        "Database timeout",
        "NullRefrenceException",
        "GPU device lost"
    ];

    private readonly int _eventCount;

    public TelemetryRandomParser(int eventCount)
    {
        _eventCount = eventCount;
    }

    public List<TelemetryEvent> Parse()
    {
        List<TelemetryEvent> events = new();

        Array severityTypes = Enum.GetValues(typeof(Severity));
        Random random = new Random();

        for (int i = 0; i < _eventCount; i++)
        {
            var dateTime = DateTime.Now;
            object? severityObject = severityTypes.GetValue(random.Next(severityTypes.Length));
            Severity severity = Severity.Info;

            if (severityObject != null)
            {
                severity = (Severity)severityObject;
            }

            string message = $"This is a telemetry event with severity: {severity}";

            switch (severity)
            {
                case Severity.Info:
                    break;
                case Severity.Warning:
                    break;
                case Severity.Error:
                    message = errorMessages[random.Next(errorMessages.Length)];
                    break;
                case Severity.Critical:
                    break;
            }

            var ev = new TelemetryEvent(dateTime, message, severity);
            events.Add(ev);
        }

        return events;
    }
}