public class TimestampGenerator
{
    private DateTime _current;
    private readonly Random _random = new Random();



    public TimestampGenerator(DateTime start, int secondsMin = 0, int secondsMax = 5)
    {
        _current = start;
    }

    public DateTime Next()
    {
        _current = _current.AddSeconds(_random.Next(0, 5));
        return _current;
    }
}