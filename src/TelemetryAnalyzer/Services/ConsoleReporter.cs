namespace Telemetry
{
    public class ConsoleReporter : IReporter
    {
        public void Report(TelemetryReport report)
        {
            Console.WriteLine();
            Console.WriteLine("--- Telemetry Report ---");
            Console.WriteLine();

            Console.WriteLine($"Info:       \t {report.InfoCount}    \t ({report.InfoCount * 100.0f / report.Total}%)");
            Console.WriteLine($"Warning:    \t {report.WarningCount} \t ({report.WarningCount * 100.0f / report.Total}%)");
            Console.WriteLine($"Error:      \t {report.ErrorCount}   \t ({report.ErrorCount * 100.0f / report.Total}%)");
            Console.WriteLine($"Critical:   \t {report.CriticalCount} \t ({report.CriticalCount * 100.0f / report.Total}%)");
            Console.WriteLine();
            Console.WriteLine($"Total:      \t {report.Total}");
            Console.WriteLine();


            // Top Errors:
            // 1. Database timeout (42)
            // 2. NullReferenceException (18)
            // 3. GPU device lost (7)

            Console.WriteLine($"Top Errors:");
            for (int i = 0; i < report.topErrors.Count(); i++)
            {
                var error = report.topErrors[i];
                Console.WriteLine($"{i + 1}. {error.Key}: {error.Value}");
            }
        }
    }
}