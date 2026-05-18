using System.Runtime.CompilerServices;
using Telemetry.Shared;

namespace Telemetry.Analyzer
{
    public class TelemetryAnalysisApp
    {
        private readonly LogFileReader _reader;
        private readonly ITelemetryParser _parser;
        private readonly ITelemetryAnalyzer _analyzer;
        private readonly IReporter _reporter;


        public TelemetryAnalysisApp(ITelemetryParser parser, ITelemetryAnalyzer analyzer, IReporter reporter)
        {
           _reader = new();
           _parser = parser;
           _analyzer = analyzer;
           _reporter = reporter; 
        }

        public void Run()
        {
            var lines = _reader.ReadLines(Paths.GetTelemetryLogPath());

            foreach(var l in lines)
            {
                Console.WriteLine(l);
            }

            var events = _parser.Parse();
            var report = _analyzer.Analyze(events);

            _reporter.Report(report);
        }
    }
}