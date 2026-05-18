using Telemetry.Shared;

namespace Telemetry;

public class TelemetryAnalyzer : ITelemetryAnalyzer
{
    public TelemetryReport Analyze(List<TelemetryEvent> events)
    {
        TelemetryReport report = new();

        report.Total = events.Count;

        report.InfoCount = events.Count(e => e.Severity == Severity.Info);
        report.WarningCount = events.Count(e => e.Severity == Severity.Warning);
        report.ErrorCount = events.Count(e => e.Severity == Severity.Error);
        report.CriticalCount = events.Count(e => e.Severity == Severity.Critical);

        report.Errors = events
            .Where(e => e.Severity == Severity.Error)
            .GroupBy(e => e.Message)
            .ToDictionary(
                group => group.Key,
                group => group.Count());

        report.topErrors = report.Errors
            .OrderByDescending(x => x.Value)
            .Take(3)
            .ToList();

        return report;
    }
}