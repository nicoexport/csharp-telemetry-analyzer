public class MachineIdGenerator
{
    public string Generate(Service service)
    {
        return service switch
        {
            Service.Renderer => "DESKTOP-01",
            Service.GPU => "DESKTOP-01",
            Service.Database => "SERVER-02",
            _ => throw new NotImplementedException(),
        };
    }
}