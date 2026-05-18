namespace Telemetry;

public class TelemetryReport
{
    public int Total {get; set;}
    public int InfoCount {get; set;}
    public int WarningCount {get; set;}
    public int ErrorCount {get; set;}
    public int CriticalCount {get; set;}

    public Dictionary<string, int> Infos {get; set;} = new();
    public Dictionary<string, int> Warning {get; set;} = new();
    public Dictionary<string, int> Errors {get; set;} = new();
    public Dictionary<string, int> Criticals {get; set;} = new();

    public List<KeyValuePair<string, int>> topErrors {get; set;} = new();
}