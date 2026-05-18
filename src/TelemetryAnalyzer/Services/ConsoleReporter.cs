namespace Telemetry.Analyzer
{
    public class ConsoleReporter : IReporter
    {
        public void Report(TelemetryReport report)
        {
            Console.WriteLine();
            Console.WriteLine("--- Telemetry Report ---");
            Console.WriteLine();

            Console.WriteLine($"{report.InfoCount} \t ({report.InfoCount * 100.0f / report.Total}%) \t INFO");
            Console.WriteLine($"{report.WarningCount} \t ({report.WarningCount * 100.0f / report.Total}%) \t WARNING");
            Console.WriteLine($"{report.ErrorCount}   \t ({report.ErrorCount * 100.0f / report.Total}%) \t ERROR");
            Console.WriteLine($"{report.CriticalCount} \t ({report.CriticalCount * 100.0f / report.Total}%) \t CRITICAL");
            Console.WriteLine();
            Console.WriteLine($"Total:      \t {report.Total}");
            Console.WriteLine();

            // --- top errors ---
            Console.WriteLine($"Top Errors:");
            for (int i = 0; i < report.topErrors.Count(); i++)
            {
                var error = report.topErrors[i];
                Console.WriteLine($"{i + 1}. {error.Key}: {error.Value}");
            }
        }
    }
}