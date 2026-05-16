namespace Telemetry
{
    public class Program
    {
        public static void Main()
        {
            var parser = new TelemetryRandomParser(20);
            var analyzer = new TelemetryAnalyzer();
            var reporter = new ConsoleReporter();

            var app = new TelemetryAnalysisApp(parser, analyzer, reporter);

            app.Run();
        }     
    }
}