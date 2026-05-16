namespace Telemetry
{
    public class TelemetryReport
    {
        public TelemetryReport(int total, int errors, int critical)
        {
            Total = total; 
            Errors = errors;
            Critical = critical;
        }

        public int Total {get; set;}
        public int Errors {get; set;}
        public int Critical {get; set;}
    }
}