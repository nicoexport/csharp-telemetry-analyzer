namespace Telemetry
{
    public class ConsoleReporter : IReporter
    {
        public void Report(TelemetryReport report)
        {
            Console.WriteLine($"Total: {report.Total}");
            Console.WriteLine($"Errors: {report.Errors}");
            Console.WriteLine($"Critical: {report.Critical}");
        }
    }
}