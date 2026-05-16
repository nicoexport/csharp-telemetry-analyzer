namespace Telemetry
{
     public class TelemetryAnalysisApp
    {
        private readonly ITelemetryParser _parser;
        private readonly ITelemetryAnalyzer _analyzer;
        private readonly IReporter _reporter;

        public TelemetryAnalysisApp(ITelemetryParser parser, ITelemetryAnalyzer analyzer, IReporter reporter)
        {
           _parser = parser;
           _analyzer = analyzer;
           _reporter = reporter; 
        }

        public void Run()
        {
            var events = _parser.Parse();
            var report = _analyzer.Analyze(events);

            _reporter.Report(report);
        }
    }
}