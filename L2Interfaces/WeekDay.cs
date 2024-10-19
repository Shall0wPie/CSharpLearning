namespace ConsoleApp1.L2Interfaces;

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