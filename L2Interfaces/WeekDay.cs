namespace ConsoleApp1;

public class WeekDay
{
    private readonly string _weekDay;

    public WeekDay(string weekDay)
    {
        _weekDay = weekDay;
    }

    public override string ToString()
    {
        return _weekDay;
    }
}