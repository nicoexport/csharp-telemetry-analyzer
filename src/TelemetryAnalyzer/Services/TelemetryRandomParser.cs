namespace Telemetry
{
    public class TelemetryRandomParser : ITelemetryParser
    {
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
                Severity severity = (Severity)severityTypes.GetValue(random.Next(severityTypes.Length));
                string message = $"This is a telemetry event with severity: {severity}";

                // switch (severity)
                // {
                //     case Severity.Info:
                //         message = "This is a Telemetry event with "
                //         break;
                //     case Severity.Warning:
                //         break;
                //     case Severity.Error:
                //         break;
                //     case Severity.Crititcal:
                //         break;
                //     default:
                //         message = "This is a Telemetry event!";
                //         break;
                // }

                var ev = new TelemetryEvent(dateTime, message, severity);
                events.Add(ev);
            }

            return events;
        }
    }
}