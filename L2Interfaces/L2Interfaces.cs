namespace ConsoleApp1;

public class L2Interfaces : ILesson
{
    public void Run()
    {
        var week = new Week();

        foreach (var weekDay in week)
        {
            Console.WriteLine($"День недели: {weekDay}");
        }
    }
}