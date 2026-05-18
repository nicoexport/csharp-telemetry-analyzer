namespace Telemetry.Analyzer
{
    public class LogFileReader
    {
        public IEnumerable<string> ReadLines(string path)
        {
            return File.ReadLines(path);
        }
    }
}