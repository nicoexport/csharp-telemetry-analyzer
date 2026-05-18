using Telemetry.Shared;

const int EVENT_COUNT = 500; 

Console.WriteLine("Generating a dummy log file!");


var path = Paths.GetTelemetryLogPath();

TelemetryEventGenerator generator = new();

using (var writer = new LogFileWriter(path))
{
    foreach (var e in generator.Generate(EVENT_COUNT))
    {
        writer.WriteLine(e);
    }
}

Console.WriteLine($"Log written to: {path}");

