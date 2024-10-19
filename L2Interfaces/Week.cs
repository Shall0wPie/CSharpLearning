using System.Collections;

namespace ConsoleApp1.L2Interfaces;

public class Week : IEnumerable<WeekDay>
{
    public IEnumerator<WeekDay> GetEnumerator()
        => new WeekDayEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}