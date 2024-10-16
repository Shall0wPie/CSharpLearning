using System.Reflection;

namespace ConsoleApp1;

public static class LessonRunner
{
    public static void ShowResult(Type lessonType)
    {
        InstantiateAndRun(lessonType);
    }

    public static void ShowAllResults()
    {
        foreach (var lessonType in GetLessonTypes())
        {
            InstantiateAndRun(lessonType);
        }
    }
    
    public static void ShowLatestLessonResult()
    {
        var lessonType = GetLessonTypes()
            .OrderByDescending(x => x.Name)
            .First();
        
        InstantiateAndRun(lessonType);
    }
    
    private static IEnumerable<Type> GetLessonTypes()
    {
        var lessonType = typeof(ILesson);
        
        return Assembly.GetAssembly(lessonType)
            .GetTypes()
            .Where(myType => myType.IsClass && myType.IsAssignableTo(lessonType));
    }

    private static void InstantiateAndRun(Type lessonType)
    {
        if (!lessonType.IsAssignableTo(typeof(ILesson)))
            throw new ArgumentException($"Type '{lessonType.Name}' is not a subclass of ILesson");
        
        Console.WriteLine($"-----{lessonType.Name}-----");
        var lesson = Activator.CreateInstance(lessonType) as ILesson;
        lesson.Run();
    }
}