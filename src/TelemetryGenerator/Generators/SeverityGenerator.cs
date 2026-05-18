using Telemetry.Shared;

public class SeverityGenerator
{
    Array _severityTypes;
    Random _random;

    public SeverityGenerator()
    {
        _severityTypes = Enum.GetValues(typeof(Severity));
        _random = new();
    }

    public Severity Generate()
    {
        object? severityObject = _severityTypes.GetValue(_random.Next(_severityTypes.Length));
        if (severityObject != null)
        {
            return (Severity)severityObject;
        }
        return Severity.Info;
    }
}
