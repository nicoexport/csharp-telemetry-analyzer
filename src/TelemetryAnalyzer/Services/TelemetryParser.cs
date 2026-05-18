using Telemetry.Shared;

namespace Telemetry.Analyzer
{
    public class TelemetryParser : ITelemetryParser
    {
        public List<TelemetryEvent> Parse(IEnumerable<string> lines)
        {
            var result = new List<TelemetryEvent>();
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {   
                    continue;
                }    

                var parts = line.Split("|");

                if (parts.Length < 5)
                {
                    continue;
                }

                if (!DateTime.TryParse(parts[0], out var timestamp))
                {
                    continue;
                }

                if(!Enum.TryParse<Severity>(parts[1], true, out var severity))
                {
                    continue;
                }

                if(!Enum.TryParse<Service>(parts[2], true, out var service))
                {
                    continue;
                }

                var machine = parts[3];
                var message = parts[4];


                var telemetryEvent = new TelemetryEvent
                {
                    Timestamp = timestamp,
                    Severity = severity,
                    Service = service,
                    MachineId = machine,
                    Message = message
                };
                result.Add(telemetryEvent);
            }
            return result;
        }
    }
}