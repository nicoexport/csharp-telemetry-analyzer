namespace Telemetry.Shared
{
    public static class Paths
    {
        public static string GetOutputDirectory()
        {
            string solutionRoot = Path.GetFullPath(
                Path.Combine(AppContext.BaseDirectory, "../../../../../"));

            string outputDir = Path.Combine(solutionRoot, "output");

            Directory.CreateDirectory(outputDir);

            return outputDir;
        }

        public static string GetTelemetryLogPath()
        {
            return Path.Combine(
                GetOutputDirectory(),
                "telemetry.log");
        }
    }
}