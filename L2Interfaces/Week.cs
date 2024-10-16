using System.Collections;

namespace ConsoleApp1;

public class Week : IEnumerable<WeekDay>
{
    public IEnumerator<WeekDay> GetEnumerator()
        => new WeekDayEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}