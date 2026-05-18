using Telemetry.Analyzer;

var parser = new TelemetryRandomParser(200);
var analyzer = new TelemetryAnalyzer();
var reporter = new ConsoleReporter();

var app = new TelemetryAnalysisApp(parser, analyzer, reporter);

app.Run();
