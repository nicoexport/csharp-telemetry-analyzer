const int EVENT_COUNT = 500; 

Console.WriteLine("Generating a dummy log file!");

TelemetryEventGenerator generator = new();

using (var writer = new LogFileWriter("telemetry.log"))
{
    foreach (var e in generator.Generate(EVENT_COUNT))
    {
        writer.WriteLine(e);
    }
}

