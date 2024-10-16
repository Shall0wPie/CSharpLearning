using System.Collections;

namespace ConsoleApp1;

public class WeekDayEnumerator : IEnumerator<WeekDay>
{
    private readonly WeekDay[] _weekDays =
    {
        new WeekDay("Понедельник"),
        new WeekDay("Вторник"),
        new WeekDay("Среда"),
        new WeekDay("Четверг"),
        new WeekDay("Пятница"),
        new WeekDay("Суббота"),
        new WeekDay("Воскресенье")
    };
    private int _index = -1;

    public bool MoveNext()
    {
        return _index++ < _weekDays.Length - 1;
    }

    public void Reset()
    {
        _index = -1;
    }

    public WeekDay Current => _weekDays[_index];

    object? IEnumerator.Current => Current;


    public void Dispose() {}
}