public class ServiceGenerator
{
    Array _serviceTypes;
    Random _random;

    public ServiceGenerator()
    {
        _serviceTypes = Enum.GetValues(typeof(Service));
        _random = new();
    }

    public Service Generate()
    {
        object? serviceObject = _serviceTypes.GetValue(_random.Next(_serviceTypes.Length ));
        if (serviceObject != null)
        {
            return (Service)serviceObject;
        }
        return Service.Renderer;
    }
}
