using Telemetry.Shared;

public class MessageGenerator
{
    public string Generate(Service service, Severity severity)
    {
        return service switch
        {
            Service.Renderer => GenerateRendererMessage(severity),
            Service.GPU => GenerateGPUMesage(severity),
            Service.Database => GenerateDatabaseMesage(severity),
            _ => throw new NotImplementedException(),
        };
    }

    private string GenerateRendererMessage(Severity severity)
    {
        return severity switch
        {
            Severity.Info => "Renderer initialized",
            Severity.Warning => "Frame time spike detected",
            Severity.Error => "Shader compilation failed",
            Severity.Critical => "Could not communicate with GPU device",
            _ => throw new NotImplementedException(),
        };
    }

    private string GenerateGPUMesage(Severity severity)
    {
        return severity switch
        {
            Severity.Info => "GPU temperature high",
            Severity.Warning => "GPU device lost",
            Severity.Error => "VRAM allocation failed",
            Severity.Critical => "Lost connection to Graphics device",
            _ => throw new NotImplementedException(),
        };
    }

    private string GenerateDatabaseMesage(Severity severity)
    {
        return severity switch
        {
            Severity.Info => "Connection retry",
            Severity.Warning => "Database timeout",
            Severity.Error => "Transaction deadlock",
            Severity.Critical => "Data corrupted",
            _ => throw new NotImplementedException(),
        };
    }
}