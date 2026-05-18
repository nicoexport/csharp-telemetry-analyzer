using Telemetry.Shared;

const int EVENT_COUNT = 500; 

Console.WriteLine("Generating a dummy log file!");

TimestampGenerator timestampGenerator = new(DateTime.UtcNow, 0, 5);
SeverityGenerator severityGenerator = new();
ServiceGenerator serviceGenerator = new();
MachineIdGenerator machineGenerator = new();
MessageGenerator messageGenerator = new();


using (var streamWriter = new StreamWriter("telemetry.log"))
{
    LogFileWriter logFileWriter = new();

    for (int i = 0; i < EVENT_COUNT; i++)
    {
        TelemetryEvent e = new();
        e.Timestamp = timestampGenerator.Next();
        e.Severity = severityGenerator.Generate();
        e.Service = serviceGenerator.Generate();
        e.MachineId = machineGenerator.Generate(e.Service);
        e.Message = messageGenerator.Generate(e.Service, e.Severity);
        logFileWriter.WriteLine(streamWriter, e);
    }
}